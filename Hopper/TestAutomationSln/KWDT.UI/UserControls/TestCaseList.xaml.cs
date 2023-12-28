using System;
using System.Collections.Generic;
using System.Windows;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using KWDT.UI.Factories;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Media;
using KWDT.Core;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for TestCaseList.xaml
    /// </summary>
    public partial class TestCaseList : ListPage
    {
        private List<TestCaseDefinition> TestCases { get; set; }
        private List<TestCaseDefinition> FilteredTestCases { get; set; }
        public string caseNameFilter { get; set; }

        private readonly IDataManager _dataManager;

        public TestCaseList(IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Cases";

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            UpdateTestCases();
            DataContext = this;
            testCount.Content = "Test Count: " + TestCases.Count;
        }

        private void UpdateTestCases()
        {
            nameFilter.Text = "";
            TestCases = _dataManager.LoadAllTestCases();
            testCases.ItemsSource = TestCases;
            FilterTestCaseList();
        }

        private void addNewTestCase_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            LoadChildPage(ChildPageFactory.CreateTestCaseEditor());
        }

        private void testCases_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TestCaseDefinition testCaseToEdit = (TestCaseDefinition)testCases.SelectedItem;
            if (testCaseToEdit != null)
            {
                TestCaseEditor testCaseEditor = ChildPageFactory.CreateTestCaseEditor();
                testCaseEditor.SetTestCase(testCaseToEdit);
                LoadChildPage(testCaseEditor);
            }
        }

        private void TestCases_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(bool) e.NewValue) return;
            UpdateTestCases();
        }

        private void SearchCaseName_Click(object sender, RoutedEventArgs e)
        {
            FilteredTestCases = new List<TestCaseDefinition>(TestCases);
            int index = 0;

            if (!String.IsNullOrWhiteSpace(caseNameFilter))
            {
                foreach (TestCaseDefinition TestCase in TestCases)
                {
                    if (!TestCase.Name.ToLower().Contains(caseNameFilter.ToLower()))
                        FilteredTestCases.RemoveAt(index);
                    else
                        index++;
                }
            }
            testCases.ItemsSource = FilteredTestCases;
            testCount.Content = "Test Count: " + FilteredTestCases.Count;
        }

        private void FilterTestCaseList_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)AllRadio.IsChecked)
            {
                ClearSearchCaseName_Click(sender, e);
                return;
            }
            else
                FilterTestCaseList();
        }

        private void FilterTestCaseList()
        {
            FilteredTestCases = new List<TestCaseDefinition>(TestCases);
            int index = 0;

            if ((bool)FTCRadio.IsChecked)
            {
                foreach (TestCaseDefinition TestCase in TestCases)
                {
                    if (!TestCase.Program.Equals("FTC"))
                        FilteredTestCases.RemoveAt(index);
                    else
                        index++;
                }
            }

            if ((bool)GardinerRadio.IsChecked)
            {
                foreach (TestCaseDefinition TestCase in TestCases)
                {
                    if (!TestCase.Program.Equals("Gardiner"))
                        FilteredTestCases.RemoveAt(index);
                    else
                        index++;
                }
            }

            if ((bool)TLERadio.IsChecked)
            {
                foreach (TestCaseDefinition TestCase in TestCases)
                {
                    if (!TestCase.Program.Equals("TLE"))
                        FilteredTestCases.RemoveAt(index);
                    else
                        index++;
                }
            }

            if ((bool)MyScholarShopRadio.IsChecked)
            {
                foreach (TestCaseDefinition TestCase in TestCases)
                {
                    if (!TestCase.Program.Equals("MyScholarShop"))
                        FilteredTestCases.RemoveAt(index);
                    else
                        index++;
                }
            }

            if ((bool)EpicoreRadio.IsChecked)
            {
                foreach (TestCaseDefinition TestCase in TestCases)
                {
                    if (!TestCase.Program.Equals("Epicore"))
                        FilteredTestCases.RemoveAt(index);
                    else
                        index++;
                }
            }

            testCases.ItemsSource = FilteredTestCases;
            testCount.Content = "Test Count: " + FilteredTestCases.Count;
        }

        private void ClearSearchCaseName_Click(object sender, RoutedEventArgs e)
        {
            caseNameFilter = "";
            nameFilter.Text = "";
            SearchCaseName_Click(sender, e);
            testCount.Content = "Test Count: " + TestCases.Count;
        }

        private void CopyCase_Click(object sender, RoutedEventArgs e)
        {
            TestCaseDefinition testCaseCopy = new TestCaseDefinition((TestCaseDefinition)((System.Windows.FrameworkElement)sender).DataContext);

            if (testCaseCopy != null)
            {
                testCaseCopy.Name = ((TestCaseDefinition)((System.Windows.FrameworkElement)sender).DataContext).Name + " - Copy";
                testCaseCopy.Program = ((TestCaseDefinition)((System.Windows.FrameworkElement)sender).DataContext).Program;

                bool restart = true;
                while (restart)
                {
                    restart = false;
                    foreach (var testCase in TestCases)
                    {
                        if (testCase.Name.Equals(testCaseCopy.Name))
                        {
                            testCaseCopy.Name += " - Copy";
                            restart = true;
                            break;
                        }
                    }
                }

                testCaseCopy.TestID = Utilities.GenerateID();

                testCaseCopy.NewTest = false;
                _dataManager.Save(testCaseCopy);
                UpdateTestCases();
            }
        }

        private void DeleteCase_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            TestCaseDefinition caseToRemove;

            caseToRemove = LocateItemInListView(e.OriginalSource);

            _dataManager.Delete(caseToRemove);
            UpdateTestCases();
        }

        private TestCaseDefinition LocateItemInListView(object source)
        {
            DependencyObject dep = (DependencyObject)source;

            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return null;

            TestCaseDefinition tCase = (TestCaseDefinition)testCases.ItemContainerGenerator.ItemFromContainer(dep);
            return tCase;
        }

        private void TestCases_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
