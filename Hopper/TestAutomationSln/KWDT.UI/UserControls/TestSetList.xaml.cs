using System;
using System.Collections.Generic;
using System.Windows;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using KWDT.UI.Factories;
using System.Windows.Controls;
using System.Windows.Media;
using KWDT.Core;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for TestSetList.xaml
    /// </summary>
    public partial class TestSetList : ListPage
    {
        protected List<TestSetDefinition> TestSets { get; set; }
        protected List<TestSetDefinition> FilteredTestSets { get; set; }
        private List<TestCaseDefinition> savedTestCases { get; set; }
        public string setNameFilter { get; set; }

        private readonly IDataManager _dataManager;

        public TestSetList(IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Sets";

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            DataContext = this;
        }

        public void UpdateTestSets()
        {
            nameFilter.Text = "";
            TestSets = _dataManager.LoadAllTestSets();
            //TestSets = UpdateTestSteps(TestSets);
            testSets.ItemsSource = TestSets;
            testCount.Content = "Test Count: " + TestSets.Count;
        }

        //Matches test cases saved in the Test Case folder to test cases in the Test Steps folder - Makes sure Test Steps are always up to date
        private List<TestSetDefinition> UpdateTestSteps(List<TestSetDefinition> testSets)
        {
            savedTestCases = _dataManager.LoadAllTestCases();

            foreach (var testSet in testSets)
            {
                for (int i = 0; i < testSet.TestCases.Count; i++)
                {
                    if (savedTestCases.Exists(x => testSet.TestCases[i].TestID == x.TestID))
                    {
                        foreach (var savedTestCase in savedTestCases)
                        {
                            if (testSet.TestCases[i].TestID == savedTestCase.TestID)
                            {
                                testSet.TestCases[i] = savedTestCase;
                                _dataManager.Save(testSet);
                                break;
                            }
                        }
                    }
                    else
                    {
                        testSet.TestCases.RemoveAt(i);
                        _dataManager.Save(testSet);
                    }
                }
            }

            return testSets;
        }

        private TestSetDefinition UpdateTestSteps(TestSetDefinition testSet)
        {
            savedTestCases = _dataManager.LoadAllTestCases();

            for (int i = 0; i < testSet.TestCases.Count; i++)
            {
                if (savedTestCases.Exists(x => testSet.TestCases[i].TestID == x.TestID))
                {
                    foreach (var savedTestCase in savedTestCases)
                    {
                        if (testSet.TestCases[i].TestID == savedTestCase.TestID)
                        {
                            testSet.TestCases[i] = savedTestCase;
                            _dataManager.Save(testSet);
                            break;
                        }
                    }
                }
                else
                {
                    testSet.TestCases.RemoveAt(i);
                    _dataManager.Save(testSet);
                }
            }

            return testSet;
        }

        private void addNewTestSet_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            LoadChildPage(ChildPageFactory.CreateTestSetEditor());
        }

        private void testSets_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TestSetDefinition testSetToEdit = (TestSetDefinition)testSets.SelectedItem;

            if (testSetToEdit != null)
            {
                TestSetEditor testSetEditor = ChildPageFactory.CreateTestSetEditor();
                TestSetDefinition updatedTestSet = UpdateTestSteps(testSetToEdit);
                testSetEditor.SetTestSet(updatedTestSet);
                LoadChildPage(testSetEditor);
            }
        }

        private void TestSets_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(bool)e.NewValue)
                return;
            UpdateTestSets();
        }

        private void SearchSetName_Click(object sender, RoutedEventArgs e)
        {
            FilteredTestSets = new List<TestSetDefinition>(TestSets);
            int index = 0;

            if (!String.IsNullOrWhiteSpace(setNameFilter))
            {
                foreach (TestSetDefinition TestSet in TestSets)
                {
                    if (!TestSet.Name.ToLower().Contains(setNameFilter.ToLower()))
                        FilteredTestSets.RemoveAt(index);
                    else
                        index++;
                }
            }

            testSets.ItemsSource = FilteredTestSets;
            testCount.Content = "Test Count: " + FilteredTestSets.Count;
        }

        private void ClearSearchSetName_Click(object sender, RoutedEventArgs e)
        {
            setNameFilter = "";
            nameFilter.Text = "";
            SearchSetName_Click(sender, e);
            testCount.Content = "Test Count: " + TestSets.Count;
        }

        private void DeleteSet_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            TestSetDefinition setToRemove;

            setToRemove = LocateItemInListView(e.OriginalSource);

            _dataManager.Delete(setToRemove);
            TestSets = _dataManager.LoadAllTestSets();
            testSets.ItemsSource = TestSets;
            testCount.Content = "Test Count: " + TestSets.Count;
        }

        private TestSetDefinition LocateItemInListView(object source)
        {
            DependencyObject dep = (DependencyObject)source;

            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return null;

            TestSetDefinition tSet = (TestSetDefinition)testSets.ItemContainerGenerator.ItemFromContainer(dep);
            return tSet;
        }

        private void CopySet_Click(object sender, RoutedEventArgs e)
        {
            TestSetDefinition testSetCopy = new TestSetDefinition((TestSetDefinition)((System.Windows.FrameworkElement)sender).DataContext);

            if (testSetCopy != null)
            {
                testSetCopy.Name = ((TestSetDefinition)((System.Windows.FrameworkElement)sender).DataContext).Name + " - Copy";

                bool restart = true;
                while (restart)
                {
                    restart = false;
                    foreach (var testSet in TestSets)
                    {
                        if (testSet.Name.Equals(testSetCopy.Name))
                        {
                            testSetCopy.Name += " - Copy";
                            restart = true;
                            break;
                        }
                    }
                }

                testSetCopy.TestID = Utilities.GenerateID();
                testSetCopy.NewTest = false;
                _dataManager.Save(testSetCopy);
                TestSets = _dataManager.LoadAllTestSets();
                testSets.ItemsSource = TestSets;
                testCount.Content = "Test Count: " + TestSets.Count;
            }
        }
    }
}
