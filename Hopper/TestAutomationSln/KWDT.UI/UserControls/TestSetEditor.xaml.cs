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
    /// Interaction logic for TestSetEditor.xaml
    /// </summary>
    public partial class TestSetEditor : EditorPage
    {
        private readonly IDataManager _dataManager;

        protected TestSetDefinition TestSet { get; set; }

        protected List<string> Programs { get; set; }

        protected List<string> Statuses { get; set; }

        protected List<string> Browsers { get; set; }

        protected List<string> Environments { get; set; }

        protected List<string> ServerEnvironments { get; set; }

        protected DateTime LastRunDate { get; set; }

        private List<TestSetDefinition> savedTestSets { get; set; }

        public TestSetEditor(IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Set Editor";

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            setStatus.ItemsSource = _dataManager.LoadStatuses();
            SetTestSet(new TestSetDefinition());

            Statuses = _dataManager.LoadStatuses();
            Browsers = _dataManager.LoadBrowsers();
            Environments = _dataManager.LoadEnvironments();
            ServerEnvironments = _dataManager.LoadServerEnvironments();
            Programs = _dataManager.LoadPrograms();

            setProgram.ItemsSource = Programs;
            setStatus.ItemsSource = Statuses;
            setBrowser.ItemsSource = Browsers;
            setEnvironment.ItemsSource = Environments;
            setServerEnvironment.ItemsSource = ServerEnvironments;
        }

        public void SetTestSet(TestSetDefinition testSet)
        {
            TestSet = testSet;
            DataContext = testSet;
            if (testSet.Name != null)
            {
                LastRunDate = File.GetLastWriteTime("C:\\KWDT Temp Repo\\Test Sets\\" + testSet.Name + ".json");
                lastRun.Content = "Last Updated: " + LastRunDate.ToString("MM/dd/yy HH:mm");
            }
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

        private void addTestCases_Click(object sender, RoutedEventArgs e)
        {
            AddTestArtifact addDialog = new AddTestArtifact(_dataManager, typeof(TestCaseDefinition));
            addDialog.Title = "Select test cases";
            if (addDialog.ShowDialog() == true)
            {
                List<TestCaseDefinition> testCasesToAdd = addDialog.SelectedTestArtifacts.Select(item => (TestCaseDefinition)item).ToList();
                TestSet.TestCases.AddRange(testCasesToAdd);
                testCases.Items.Refresh();
            }
        }

        private new void EditorButtons_EditorSave(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TestSet.Name))
            {
                if (Utilities.IsValidFilename(TestSet.Name))
                {
                    if (TestSet.TestCases.Count > 0)
                    {
                        savedTestSets = _dataManager.LoadAllTestSets();

                        foreach (var savedTestSet in savedTestSets)
                        {
                            if (savedTestSet.Name.ToLower() == TestSet.Name.ToLower() && TestSet.NewTest == true)
                            {
                                MessageBox.Show("A test set with that name already exists. Select a new name.", "Duplicate Test Set", MessageBoxButton.OK);
                                return;
                            }
                            if (savedTestSet.Name.ToLower() == TestSet.Name.ToLower() && TestSet.NewTest == false && savedTestSet.TestID != TestSet.TestID)
                            {
                                MessageBox.Show("A test set with that name already exists. Select a new name.", "Duplicate Test Set", MessageBoxButton.OK);
                                return;
                            }

                            if (savedTestSet.Name.ToLower() != TestSet.Name.ToLower() && savedTestSet.TestID == TestSet.TestID && TestSet.NewTest == false)
                            {
                                if (!savedTestSets.Exists(x => TestSet.Name.ToLower() == x.Name.ToLower()))
                                {
                                    _dataManager.Delete(savedTestSet);
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("A test set with that name already exists. Select a new name.", "Duplicate Test Set", MessageBoxButton.OK);
                                    return;
                                }
                            }

                            if (savedTestSet.Name.ToLower() == TestSet.Name.ToLower() && TestSet.NewTest == false)
                            {
                                break;
                            }
                        }

                        if (TestSet.NewTest == true)
                        {
                            TestSet.NewTest = false;
                            TestSet.TestID = Utilities.GenerateID();
                        }

                        if (TestSet.Description != null && TestSet.Description.Equals(""))
                            TestSet.Description = null;

                        ConfirmSave();
                        _dataManager.Save(TestSet);
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Must add at least one test case before saving test set.", "Test Steps Missing", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Test name contains one of the following invalid characters: \\ / : * ? \" < > | '", "Invalid Test Name", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Must provide test name before saving test set.", "Test Name Missing", MessageBoxButton.OK);
            }
        }

        private new void EditorButtons_EditorDelete(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            _dataManager.Delete(TestSet);
            CloseChildPage();
        }

        private void deleteCase_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            TestCaseDefinition caseToRemove = LocateItemInListView(e.OriginalSource);
            int indexToRemoveFrom = TestSet.TestCases.IndexOf(caseToRemove);

            TestSet.TestCases.RemoveAt(indexToRemoveFrom);
            testCases.Items.Refresh();
        }

        private void run_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            if (!String.IsNullOrWhiteSpace(TestSet.Name))
            {
                if (TestSet.TestCases.Count > 0)
                {
                    TestRunner testRunner = ChildPageFactory.CreateTestRunner();
                    testRunner.SetTestToRun(TestSet);
                    LoadChildPage(testRunner);
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Must add at least one test case before running test.", "Test Cases Missing", MessageBoxButton.OK);
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

			if (TestSet.TestCases.Count > 0)
			{
				foreach (var testCase in TestSet.TestCases)
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
								graphString += ";" + testCase.TestSteps[i].Entity + "-->" + testCase.TestSteps[i + 1].Entity;
								numeratedGraphString += ";" + testCase.TestSteps[i].Entity + "-->|" + counter + "|" + testCase.TestSteps[i + 1].Entity;
								lastStep = ";" + testCase.TestSteps[i + 1].Entity + "-->" + "End((End))";
								counter++;
							}
						}
					}
				}

				System.Windows.Clipboard.SetText(numeratedGraphString += lastStep);
				System.Diagnostics.Process.Start("https://mermaidjs.github.io/mermaid-live-editor");
			}
			else
			{
				MessageBoxResult result = MessageBox.Show("Must add at least one test case before generating workflow graph.", "Test Cases Missing", MessageBoxButton.OK);
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
            TestCaseDefinition stepToMove;

            stepToMove = LocateItemInListView(e.OriginalSource);
            int indexToMoveFrom = TestSet.TestCases.IndexOf(stepToMove);

            TestSet.TestCases.RemoveAt(indexToMoveFrom);
            TestSet.TestCases.Insert(indexToMoveFrom + offset, stepToMove);
            testCases.Items.Refresh();
        }

		private void testSteps_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			DependencyObject dep = (DependencyObject)e.OriginalSource;

			while ((dep != null) && !(dep is ListViewItem))
			{
				dep = VisualTreeHelper.GetParent(dep);
			}

			if (dep != null)
			{
				TestCasePreview preview = new TestCasePreview(_dataManager, ((KWDT.Core.TestDefinitions.BaseTestArtifact)((System.Windows.Controls.ContentControl)dep).Content).Name);
				preview.Title = "Test Steps";
				preview.ShowDialog();
			}
		}
	}
}
