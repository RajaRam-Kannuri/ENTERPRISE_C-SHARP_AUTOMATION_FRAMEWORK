using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using System.IO;
using KWDT.Core;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for TestSuiteEditor.xaml
    /// </summary>
    public partial class TestSuiteEditor : EditorPage
    {
        private readonly IDataManager _dataManager;

        protected TestSuiteDefinition TestSuite { get; set; }

        protected List<string> Programs { get; set; }

        protected List<string> Statuses { get; set; }

        protected List<string> Browsers { get; set; }

        protected List<string> Environments { get; set; }

        protected List<string> ServerEnvironments { get; set; }

        protected DateTime LastRunDate { get; set; }

        private List<TestSuiteDefinition> savedTestSuites { get; set; }

        public TestSuiteEditor(IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Suite Editor";

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            suiteStatus.ItemsSource = _dataManager.LoadStatuses();
            SetTestSuite(new TestSuiteDefinition());

            Programs = _dataManager.LoadPrograms();
            Statuses = _dataManager.LoadStatuses();
            Browsers = _dataManager.LoadBrowsers();
            Environments = _dataManager.LoadEnvironments();
            ServerEnvironments = _dataManager.LoadServerEnvironments();

            suiteProgram.ItemsSource = Programs;
            suiteStatus.ItemsSource = Statuses;
            suiteBrowser.ItemsSource = Browsers;
            suiteEnvironment.ItemsSource = Environments;
            suiteServerEnvironment.ItemsSource = ServerEnvironments;
        }

        public void SetTestSuite(TestSuiteDefinition testSuite)
        {
            TestSuite = testSuite;
            DataContext = testSuite;
            testSetCount.Content = "Test Set Count: " + testSuite.TestSets.Count;
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

            TestSetDefinition tCase = (TestSetDefinition)testSets.ItemContainerGenerator.ItemFromContainer(dep);
            return tCase;
        }

        private void addTestSets_Click(object sender, RoutedEventArgs e)
        {
            AddTestArtifact addDialog = new AddTestArtifact(_dataManager, typeof(TestSetDefinition));
            addDialog.Title = "Select test sets";
            if (addDialog.ShowDialog() == true)
            {
                List<TestSetDefinition> testSetsToAdd = addDialog.SelectedTestArtifacts.Select(item => (TestSetDefinition)item).ToList();
                TestSuite.TestSets.AddRange(testSetsToAdd);
                testSets.Items.Refresh();
            }

            testSetCount.Content = "Test Set Count: " + testSets.Items.Count;
        }

        private new void EditorButtons_EditorSave(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            if (!String.IsNullOrWhiteSpace(TestSuite.Name))
            {
                if (Utilities.IsValidFilename(TestSuite.Name))
                {
                    if (TestSuite.TestSets.Count > 0)
                    {
                        savedTestSuites = _dataManager.LoadAllTestSuites();

                        foreach (var savedTestSuite in savedTestSuites)
                        {
                            if (savedTestSuite.Name.ToLower() == TestSuite.Name.ToLower() && TestSuite.NewTest == true)
                            {
                                MessageBox.Show("A test suite with that name already exists. Select a new name.", "Duplicate Test Suite", MessageBoxButton.OK);
                                return;
                            }
                            if (savedTestSuite.Name.ToLower() == TestSuite.Name.ToLower() && TestSuite.NewTest == false && savedTestSuite.TestID != TestSuite.TestID)
                            {
                                MessageBox.Show("A test suite with that name already exists. Select a new name.", "Duplicate Test Suite", MessageBoxButton.OK);
                                return;
                            }

                            if (savedTestSuite.Name.ToLower() != TestSuite.Name.ToLower() && savedTestSuite.TestID == TestSuite.TestID && TestSuite.NewTest == false)
                            {
                                if (!savedTestSuites.Exists(x => TestSuite.Name.ToLower() == x.Name.ToLower()))
                                {
                                    _dataManager.Delete(savedTestSuite);
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("A test suite with that name already exists. Select a new name.", "Duplicate Test Suite", MessageBoxButton.OK);
                                    return;
                                }
                            }

                            if (savedTestSuite.Name.ToLower() == TestSuite.Name.ToLower() && TestSuite.NewTest == false)
                            {
                                break;
                            }
                        }

                        if (TestSuite.NewTest == true)
                        {
                            TestSuite.NewTest = false;
                            TestSuite.TestID = Utilities.GenerateID();
                        }

                        ConfirmSave();
                        _dataManager.Save(TestSuite);
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Must add at least one test set before saving test.", "Test Sets Missing", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Test name contains one of the following invalid characters: \\ / : * ? \" < > | '", "Invalid Test Name", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Must provide test name before saving test suite.", "Test Name Missing", MessageBoxButton.OK);
            }
        }

        private new void EditorButtons_EditorDelete(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            _dataManager.Delete(TestSuite);
            CloseChildPage();
        }

        private void deleteSet_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            TestSetDefinition setToRemove;

            setToRemove = LocateItemInListView(e.OriginalSource);
            int indexToRemoveFrom = TestSuite.TestSets.IndexOf(setToRemove);

            TestSuite.TestSets.RemoveAt(indexToRemoveFrom);
            testSets.Items.Refresh();
            testSetCount.Content = "Test Set Count: " + testSets.Items.Count;
        }

        private void run_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            if (!String.IsNullOrWhiteSpace(TestSuite.Name))
            {
                if (TestSuite.TestSets.Count > 0)
                {
                    TestRunner testRunner = ChildPageFactory.CreateTestRunner();
                    testRunner.SetTestToRun(TestSuite);
                    LoadChildPage(testRunner);
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Must add at least one test set before running test.", "Test Sets Missing", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Must provide test name before running test.", "Test Name Missing", MessageBoxButton.OK);
            }
        }

		private void generateWorkflowGraph_Click(object sender, RoutedEventArgs e)
		{
			String graphString = "graph LR";
			String numeratedGraphString = "graph LR";
			string lastStep = String.Empty;
			int counter = 1;

			if (ChildPageFactory == null)
				throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

			if (TestSuite.TestSets.Count > 0)
			{
				foreach (var testSet in TestSuite.TestSets)
				{
					foreach (var testCase in testSet.TestCases)
					{
						for (int i = 0; i < testCase.TestSteps.Count - 1; i++)
						{
							if (i == 0)
							{
								graphString += ";" + testCase.TestSteps[i].Entity;
								numeratedGraphString += ";" + testCase.TestSteps[i].Entity;
								lastStep = ";" + testCase.TestSteps[i].Entity + "-->" + "End((End))";
							}

							if (!testCase.TestSteps[i].Entity.Equals(testCase.TestSteps[i + 1].Entity))
							{
								if (!graphString.Contains(testCase.TestSteps[i].Entity + "-->" + testCase.TestSteps[i + 1].Entity))
								{
									graphString += "\r\n" + testCase.TestSteps[i].Entity + "-->" + testCase.TestSteps[i + 1].Entity;
									numeratedGraphString += ";" + testCase.TestSteps[i].Entity + "-->|" + counter + "|" + testCase.TestSteps[i + 1].Entity;
									lastStep = ";" + testCase.TestSteps[i + 1].Entity + "-->" + "End((End))";
									counter++;
								}
							}
						}
					}
				}

				System.Windows.Clipboard.SetText(numeratedGraphString += lastStep);
				System.Diagnostics.Process.Start("https://mermaidjs.github.io/mermaid-live-editor");
			}
			else
			{
				MessageBoxResult result = MessageBox.Show("Must add at least one test set before generating workflow graph.", "Test Sets Missing", MessageBoxButton.OK);
			}
		}

		private void MoveStepUp_Click(object sender, RoutedEventArgs e)
        {
            MoveStep(e, -1);
        }

        private void MoveStepDown_Click(object sender, RoutedEventArgs e)
        {
            MoveStep(e, 1);
        }

        private void MoveStep(RoutedEventArgs e, int offset)
        {
            TestSetDefinition stepToMove;

            stepToMove = LocateItemInListView(e.OriginalSource);
            int indexToMoveFrom = TestSuite.TestSets.IndexOf(stepToMove);

            TestSuite.TestSets.RemoveAt(indexToMoveFrom);
            TestSuite.TestSets.Insert(indexToMoveFrom + offset, stepToMove);
            testSets.Items.Refresh();
        }
    }
}
