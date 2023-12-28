using System;
using System.Collections.Generic;
using System.Windows;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using System.Windows.Controls;
using System.Windows.Media;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for TestSuiteList.xaml
    /// </summary>
    public partial class TestSuiteList : ListPage
    {
        protected List<TestSuiteDefinition> TestSuites { get; set; }
        protected List<TestSuiteDefinition> FilteredTestSuites { get; set; }
        private List<TestSetDefinition> savedTestSets { get; set; }
        private List<TestCaseDefinition> savedTestCases { get; set; }
        public string suiteNameFilter { get; set; }

        private readonly IDataManager _dataManager;

        public TestSuiteList(IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Suites";

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            TestSetList tempSetList = new TestSetList(dataManager);
            tempSetList.UpdateTestSets();

            //UpdateTestSuites();
            DataContext = this;
            //testCount.Content = "Test Count: " + TestSuites.Count;
        }

        private void UpdateTestSuites()
        {
            nameFilter.Text = "";
            TestSuites = _dataManager.LoadAllTestSuites();
            //TestSuites = UpdateTestSets(TestSuites);
            testSuites.ItemsSource = TestSuites;
            testCount.Content = "Test Count: " + TestSuites.Count;
        }

        //Matches test sets saved in the Test Set folder to test sets in the Test Suites folder - Makes sure Test Sets and Test Steps are always up to date
        private List<TestSuiteDefinition> UpdateTestSets(List<TestSuiteDefinition> testSuites)
        {
            savedTestSets = _dataManager.LoadAllTestSets();

            foreach (var testSuite in testSuites)
            {
                for (int i = 0; i < testSuite.TestSets.Count; i++)
                {
                    if (savedTestSets.Exists(x => testSuite.TestSets[i].TestID == x.TestID))
                    {
                        foreach (var savedTestSet in savedTestSets)
                        {
                            if (testSuite.TestSets[i].TestID == savedTestSet.TestID)
                            {
                                testSuite.TestSets[i] = savedTestSet;
                                _dataManager.Save(testSuite);
                                break;
                            }
                        }
                    }
                    else
                    {
                        testSuite.TestSets.RemoveAt(i);
                        _dataManager.Save(testSuite);
                    }
                }
            }

            return testSuites;
        }

        private TestSuiteDefinition UpdateTestSets(TestSuiteDefinition testSuite)
        {
            savedTestSets = _dataManager.LoadAllTestSets();

            for (int i = 0; i < testSuite.TestSets.Count; i++)
            {
                if (savedTestSets.Exists(x => testSuite.TestSets[i].TestID == x.TestID))
                {
                    foreach (var savedTestSet in savedTestSets)
                    {
                        if (testSuite.TestSets[i].TestID == savedTestSet.TestID)
                        {
                            //update test set here first then load into test suite
                            TestSetDefinition updatedTestSet = UpdateTestSteps(savedTestSet);
                            testSuite.TestSets[i] = updatedTestSet;
                            _dataManager.Save(testSuite);
                            break;
                        }
                    }
                }
                else
                {
                    testSuite.TestSets.RemoveAt(i);
                    _dataManager.Save(testSuite);
                }
            }

            return testSuite;
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

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            CloseChildPage();
        }

        private void addNewTestSuite_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            LoadChildPage(ChildPageFactory.CreateTestSuiteEditor());
        }

        private void testSuites_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TestSuiteDefinition testSuiteToEdit = (TestSuiteDefinition)testSuites.SelectedItem;

            if (testSuiteToEdit != null)
            {
                TestSuiteEditor testSuiteEditor = ChildPageFactory.CreateTestSuiteEditor();
                TestSuiteDefinition updatedTestSuite = UpdateTestSets(testSuiteToEdit);
                testSuiteEditor.SetTestSuite(updatedTestSuite);
                LoadChildPage(testSuiteEditor);
            }
        }

        private void TestSuites_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(bool)e.NewValue)
                return;
            UpdateTestSuites();
        }

        private void SearchSuiteName_Click(object sender, RoutedEventArgs e)
        {
            FilteredTestSuites = new List<TestSuiteDefinition>(TestSuites);
            int index = 0;

            if (!String.IsNullOrWhiteSpace(suiteNameFilter))
            {
                foreach (TestSuiteDefinition TestSuite in TestSuites)
                {
                    if (!TestSuite.Name.ToLower().Contains(suiteNameFilter.ToLower()))
                        FilteredTestSuites.RemoveAt(index);
                    else
                        index++;
                }
            }
            testSuites.ItemsSource = FilteredTestSuites;
            testCount.Content = "Test Count: " + FilteredTestSuites.Count;
        }

        private void ClearSearchSuiteName_Click(object sender, RoutedEventArgs e)
        {
            suiteNameFilter = "";
            nameFilter.Text = "";
            SearchSuiteName_Click(sender, e);
            testCount.Content = "Test Count: " + TestSuites.Count;
        }

        private void DeleteSuite_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            TestSuiteDefinition suiteToRemove;

            suiteToRemove = LocateItemInListView(e.OriginalSource);

            _dataManager.Delete(suiteToRemove);
            TestSuites = _dataManager.LoadAllTestSuites();
            testSuites.ItemsSource = TestSuites;
            testCount.Content = "Test Count: " + TestSuites.Count;
        }

        private TestSuiteDefinition LocateItemInListView(object source)
        {
            DependencyObject dep = (DependencyObject)source;

            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return null;

            TestSuiteDefinition tSuite = (TestSuiteDefinition)testSuites.ItemContainerGenerator.ItemFromContainer(dep);
            return tSuite;
        }
    }
}
