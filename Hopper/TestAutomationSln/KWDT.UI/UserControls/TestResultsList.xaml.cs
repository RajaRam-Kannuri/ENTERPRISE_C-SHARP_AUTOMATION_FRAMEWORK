using System;
using System.Collections.Generic;
using System.Windows;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using KWDT.UI.Factories;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;

namespace KWDT.UI.UserControls
{
    public partial class TestResultsList : ListPage
    {
        protected List<TestResultDefinition> TestResults { get; set; }
        protected List<TestResultDefinition> FilteredTestResults { get; set; }
        public string resultNameFilter { get; set; }
        private readonly IDataManager _dataManager;

        public TestResultsList(IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Results";

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            UpdateTestResults();
            DataContext = this;
        }

        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        void GridViewColumnHeaderClickedHandler(object sender,
                                                RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != _lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        if (_lastDirection == ListSortDirection.Ascending)
                        {
                            direction = ListSortDirection.Descending;
                        }
                        else
                        {
                            direction = ListSortDirection.Ascending;
                        }
                    }

                    var columnBinding = headerClicked.Column.DisplayMemberBinding as Binding;
                    var sortBy = columnBinding?.Path.Path ?? headerClicked.Column.Header as string;

                    Sort(sortBy, direction);

                    if (direction == ListSortDirection.Ascending)
                    {
                        headerClicked.Column.HeaderTemplate =
                          Resources["HeaderTemplateArrowUp"] as DataTemplate;
                    }
                    else
                    {
                        headerClicked.Column.HeaderTemplate =
                          Resources["HeaderTemplateArrowDown"] as DataTemplate;
                    }

                    // Remove arrow from previously sorted header  
                    if (_lastHeaderClicked != null && _lastHeaderClicked != headerClicked)
                    {
                        _lastHeaderClicked.Column.HeaderTemplate = null;
                    }

                    _lastHeaderClicked = headerClicked;
                    _lastDirection = direction;
                }
            }
        }
        private void Sort(string sortBy, ListSortDirection direction)
        {
            //switch (sortBy)
            //{
            //    case ("Name"):
            //        TestResults.Sort((x, y) => -1 * x.Name.CompareTo(y.Name));
            //        testResults.ItemsSource = TestResults;
            //        break;
            //    case "Type":
            //        //TestResults.Sort((x, y) => -1 * x.Type.CompareTo(y.Type));
            //        testResults.ItemsSource = TestResults; break;
            //    case "Date Modified":
            //        TestResults.Sort((x, y) => -1 * x.DateModified.CompareTo(y.DateModified));
            //        testResults.ItemsSource = TestResults;
            //        break;
            //}

            //TestResults.Sort((x, y) => -1 * x.DateModified.CompareTo(y.DateModified));
            //testResults.ItemsSource = TestResults;


            ICollectionView dataView = CollectionViewSource.GetDefaultView(testResults.ItemsSource);

            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

        private void UpdateTestResults()
        {
            nameFilter.Text = "";
            TestResults = _dataManager.LoadAllTestResults();
            //TestResults.Sort((x, y) => -1 * x.DateModified.CompareTo(y.DateModified));
            TestResults.Sort((x, y) => DateTime.Compare(DateTime.Parse(x.DateModified), DateTime.Parse(y.DateModified)));
            TestResults.Reverse();
            testResults.ItemsSource = TestResults;
        }
       
        private void testResults_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TestResultDefinition testResultToView = (TestResultDefinition)testResults.SelectedItem;

            if (testResultToView != null)
            {
                try
                {
                    System.Diagnostics.Process.Start("C:\\KWDT Temp Repo\\Test Results\\" + testResultToView.TestType + "s\\" + testResultToView.Name + ".html");
                }
                catch
                {
                    MessageBoxResult noResult = MessageBox.Show("Test report does not exist.", "Results Missing", MessageBoxButton.OK);
                }
            }
        }

        private void TestResults_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(bool)e.NewValue) return;
            UpdateTestResults();
        }

        private void SearchResultName_Click(object sender, RoutedEventArgs e)
        {
            FilteredTestResults = new List<TestResultDefinition>(TestResults);
            int index = 0;

            if (!String.IsNullOrWhiteSpace(resultNameFilter))
            {
                foreach (TestResultDefinition TestResult in TestResults)
                {
                    if (!TestResult.Name.ToLower().Contains(resultNameFilter.ToLower()) && !TestResult.TestType.ToLower().Contains(resultNameFilter.ToLower()))
                        FilteredTestResults.RemoveAt(index);
                    else
                        index++;
                }
            }

            FilteredTestResults.Sort((x, y) => DateTime.Compare(DateTime.Parse(x.DateModified), DateTime.Parse(y.DateModified)));
            FilteredTestResults.Reverse();
            testResults.ItemsSource = FilteredTestResults;
        }

        private void ClearSearchResultName_Click(object sender, RoutedEventArgs e)
        {
            resultNameFilter = "";
            nameFilter.Text = "";
            SearchResultName_Click(sender, e);
        }
    }
}
