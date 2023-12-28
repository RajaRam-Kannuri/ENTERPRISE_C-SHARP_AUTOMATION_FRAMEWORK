using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Data;
using AutomationFramework;
using KWDT.Core;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using PageMinders;
using System.IO;

namespace KWDT.UI.UserControls
{
    public partial class TestCaseEditor : EditorPage
    {
        protected TestCaseDefinition TestCase { get; set; }

        private List<TestCaseDefinition> savedTestCases { get; set; }

        protected DateTime LastRunDate { get; set; }

        protected List<string> Statuses { get; set; }

        protected List<string> Browsers { get; set; }

        protected List<string> Environments { get; set; }

        protected List<string> ServerEnvironments { get; set; }

        protected List<string> Programs { get; set; }

        protected List<string> RunTypes { get; set; }

        private TestStepDefinition latestTestStep = null;

        private List<StepProgram> _pagesByProgram;

        private List<StepControlType> _methodsByControlType;

        private readonly IAutomationFrameworkExaminer _frameworkExaminer;

        private readonly IMinderFactory _minderFactory;

        private readonly IDataManager _dataManager;

        private readonly IConfigurationProvider _configurationProvider;

        public TestCaseEditor(IAutomationFrameworkExaminer frameworkExaminer, IMinderFactory minderFactory, IDataManager dataManager, IConfigurationProvider configurationProvider)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Case Editor";

            _pagesByProgram = new List<StepProgram>();
            _methodsByControlType = new List<StepControlType>();

            if (minderFactory == null)
                throw new ArgumentNullException(nameof(minderFactory));

            _minderFactory = minderFactory;

            if (frameworkExaminer == null)
                throw new ArgumentNullException(nameof(frameworkExaminer));

            _frameworkExaminer = frameworkExaminer;

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

            if (configurationProvider == null)
                throw new ArgumentNullException(nameof(configurationProvider));

            _configurationProvider = configurationProvider;

            CollectPages();
            CollectMethodsByControlType();

            Statuses = _dataManager.LoadStatuses();
            Browsers = _dataManager.LoadBrowsers();
            Environments = _dataManager.LoadEnvironments();
            ServerEnvironments = _dataManager.LoadServerEnvironments();
            Programs = _dataManager.LoadPrograms();
            RunInjectionTestString.Text = "~`!@#$%&*'\"<>?+/\\{}()";

            caseStatus.ItemsSource = Statuses;
            caseBrowser.ItemsSource = Browsers;
            caseEnvironment.ItemsSource = Environments;
            caseServerEnvironment.ItemsSource = ServerEnvironments;
            caseProgram.ItemsSource = Programs;
            SetTestCase(new TestCaseDefinition());
        }

        public void SetTestCase(TestCaseDefinition testCase)
        {
            TestCase = testCase;
            DataContext = TestCase;
            if (testCase.Name != null)
            {
                LastRunDate = File.GetLastWriteTime("C:\\KWDT Temp Repo\\Test Cases\\" + testCase.Name + ".json");
                lastRun.Content = "Last Updated: " + LastRunDate.ToString("MM/dd/yy HH:mm");
            }

            if (String.IsNullOrEmpty(TestCase.InjectionString))
                RunInjectionTest.IsChecked = false;
            else
            {
                RunInjectionTest.IsChecked = true;
                RunInjectionTestString.Text = TestCase.InjectionString;
            }
        }

		public bool TestCaseUpdated()
		{
			return TestCase == TestCase;
		}

        public void CollectPages()
        {
            Type[] minderTypes = _minderFactory.GetAvailableMinderTypes();

            foreach (Type minderType in minderTypes)
            {
                StepProgram program = new StepProgram();
                program.Name = minderType.Name;

                _frameworkExaminer.GetAutomationFrameworkAssembly();

                // Collect the names of our pages
                List<PropertyInfo> minderPages = minderType.GetProperties().ToList().Where(prop => prop.Name.Contains("Page")).ToList();
                List<string> minderPageNames = minderPages.Select(mnd => mnd.Name).ToList().OrderBy(name => name).ToList();

                // Add the elements per page and give each one a named range that includes the page name
                minderPages.ForEach(minderPage =>
                {
                    Type pageType = Type.GetType(minderPage.PropertyType.AssemblyQualifiedName);
                    List<PropertyInfo> pageElements = pageType.GetProperties().Where(prop => prop.PropertyType.FullName.Contains("Automation")).OrderBy(prop => prop.PropertyType.FullName).ToList();
                    List<Tuple<string, string>> elementsWithTypes = new List<Tuple<string, string>>();

                    pageElements.ForEach(element =>
                    {
                        if (element.PropertyType.Name.Contains("Section"))
                        {
                            Type sectionType = Type.GetType(element.PropertyType.AssemblyQualifiedName);
                            List<PropertyInfo> sectionElements = sectionType.GetProperties().Where(prop => prop.PropertyType.FullName.Contains("Automation")).ToList();
                            sectionElements.ForEach(sectionElement => elementsWithTypes.Add(new Tuple<string, string>(sectionElement.Name, sectionElement.PropertyType.Name)));
                        }
                        else
                        {
                            elementsWithTypes.Add(new Tuple<string, string>(element.Name, element.PropertyType.Name));
                        }
                    });


                    StepPage stepPage = new StepPage();
                    stepPage.Name = pageType.Name;
                    elementsWithTypes.ForEach(elem =>
                    {
                        StepControl control = new StepControl();
                        control.Name = elem.Item1;
                        control.Type = elem.Item2;
                        stepPage.Controls.Add(control);
                    });

                    program.Pages.Add(stepPage);

                });

                _pagesByProgram.Add(program);
            }
        }

        public void CollectMethodsByControlType()
        {
            var keywordTestingTypes = _frameworkExaminer.GetKeywordTestingTypes();
            keywordTestingTypes.ForEach(type =>
            {
                StepControlType controlType = new StepControlType();

                controlType.Type = type.Name;
                var methods = _frameworkExaminer.GetMethodsByControlType(type.Name);
                controlType.Methods = methods.Select(meth => meth.Name).ToList();
                _methodsByControlType.Add(controlType);

            });
        }

        private TestStepDefinition LocateItemInListView(object source)
        {
            DependencyObject dep = (DependencyObject)source;

            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return null;

            TestStepDefinition step = (TestStepDefinition)testSteps.ItemContainerGenerator.ItemFromContainer(dep);
            return step;
        }

        private void MoveStep(RoutedEventArgs e, int offset)
        {
            TestStepDefinition stepToMove;

            stepToMove = LocateItemInListView(e.OriginalSource);
            int indexToMoveFrom = TestCase.TestSteps.IndexOf(stepToMove);

            TestCase.TestSteps.RemoveAt(indexToMoveFrom);
            TestCase.TestSteps.Insert(indexToMoveFrom + offset, stepToMove);
            testSteps.Items.Refresh();
        }

        private new void EditorButtons_EditorSave(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TestCase.Name))
            {
                if (Utilities.IsValidFilename(TestCase.Name))
                {
                    if (TestCase.TestSteps.Count > 0)
                    {
                        savedTestCases = _dataManager.LoadAllTestCases();

                        foreach (var savedTestCase in savedTestCases)
                        {
                            if (savedTestCase.Name.ToLower() == TestCase.Name.ToLower() && TestCase.NewTest == true)
                            {
                                MessageBox.Show("A test case with that name already exists. Select a new name.", "Duplicate Test Case", MessageBoxButton.OK);
                                return;
                            }
                            if (savedTestCase.Name.ToLower() == TestCase.Name.ToLower() && TestCase.NewTest == false && savedTestCase.TestID != TestCase.TestID)
                            {
                                MessageBox.Show("A test case with that name already exists. Select a new name.", "Duplicate Test Case", MessageBoxButton.OK);
                                return;
                            }

                            if (savedTestCase.Name.ToLower() != TestCase.Name.ToLower() && savedTestCase.TestID == TestCase.TestID && TestCase.NewTest == false)
                            {
                                if (!savedTestCases.Exists(x => TestCase.Name.ToLower() == x.Name.ToLower()))
                                {
                                    _dataManager.Delete(savedTestCase);
									foreach (var savedCase in savedTestCases)
									{
										foreach (var testStep in savedCase.TestSteps)
										{
											if (testStep.Entity.Equals(savedTestCase.Name))
											{
												testStep.Entity = TestCase.Name;
												_dataManager.Save(savedCase);
											}
										}
									}

									break;
                                }
                                else
                                {
                                    MessageBox.Show("A test case with that name already exists. Select a new name.", "Duplicate Test Case", MessageBoxButton.OK);
                                    return;
                                }
                            }

                            if (savedTestCase.Name.ToLower() == TestCase.Name.ToLower() && TestCase.NewTest == false)
                            {
                                break;
                            }
                        }

                        if (TestCase.NewTest == true)
                        {
                            TestCase.NewTest = false;

                            TestCase.TestID = Utilities.GenerateID();
                        }

                        foreach (var testStep in TestCase.TestSteps)
                        {
                            testStep.Breakpoint = false;
                            testStep.Delete = false;
                        }
                        if (TestCase.Description != null && TestCase.Description.Equals(""))
                            TestCase.Description = null;

                        if ((bool)RunInjectionTest.IsChecked && !String.IsNullOrEmpty(RunInjectionTestString.Text))
                            TestCase.InjectionString = RunInjectionTestString.Text;
                        else if (!(bool)RunInjectionTest.IsChecked)
                            TestCase.InjectionString = String.Empty;

                        ConfirmSave();
                        _dataManager.Save(TestCase);
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Must add at least one test step before saving test.", "Test Steps Missing", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Test name contains one of the following invalid characters: \\ / : * ? \" < > | '", "Invalid Test Name", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Must provide test name before saving test case.", "Test Name Missing", MessageBoxButton.OK);
            }
        }

        private new void EditorButtons_EditorDelete(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            _dataManager.Delete(TestCase);
            CloseChildPage();
        }

        private void MoveStepUp_Click(object sender, RoutedEventArgs e)
        {
            MoveStep(e, -1);
        }

        private void MoveStepDown_Click(object sender, RoutedEventArgs e)
        {
            MoveStep(e, 1);
        }

        private void DeleteStep_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            TestStepDefinition stepToRemove;

            stepToRemove = LocateItemInListView(e.OriginalSource);
            int indexToRemoveFrom = TestCase.TestSteps.IndexOf(stepToRemove);

            TestCase.TestSteps.RemoveAt(indexToRemoveFrom);
            testSteps.Items.Refresh();
        }

        private void DeleteSteps_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmMultipleDelete())
                return;

            List<int> testStepsToDelete = new List<int> { }; 

            foreach (var testStep in testSteps.Items)
            {
                if ((bool)((KWDT.Core.TestDefinitions.TestStepDefinition)testSteps.Items[testSteps.Items.IndexOf(testStep)]).Delete)
                    testStepsToDelete.Add(testSteps.Items.IndexOf(testStep));
            }

            testStepsToDelete.Reverse();

            foreach (var testStepToDelete in testStepsToDelete)
            {
                TestCase.TestSteps.RemoveAt(testStepToDelete);
            }

            testSteps.Items.Refresh();
        }

        private void EditStep_Click(object sender, RoutedEventArgs e)
        {
            TestStepDefinition stepToEdit;

            stepToEdit = LocateItemInListView(e.OriginalSource);

            if (stepToEdit != null && !stepToEdit.SharedStep)
            {
                int indexToEdit = TestCase.TestSteps.IndexOf(stepToEdit);
                AddEditStepWizard popup = new AddEditStepWizard(_frameworkExaminer, _minderFactory, _dataManager, _configurationProvider);
                popup.TestStep = stepToEdit;
                bool? dialogResult = popup.ShowDialog();
                if (dialogResult == true)
                {
                    TestStepDefinition step = popup.TestStep;
                    TestCase.TestSteps[indexToEdit] = new TestStepDefinition(step);
                    testSteps.Items.Refresh();
                }
            }

			if (stepToEdit != null && stepToEdit.SharedStep)
			{
				TestCasePreview preview = new TestCasePreview(_dataManager, stepToEdit.Entity);
				preview.Title = "Test Steps";
				preview.ShowDialog();
			}
        }

        private void addTestStep_Click(object sender, RoutedEventArgs e)
        {
            TestStepDefinition stepToEdit;
            AddEditStepWizard popup = new AddEditStepWizard(_frameworkExaminer, _minderFactory, _dataManager, _configurationProvider);

            if (latestTestStep != null)
            {
                popup.TestStep = latestTestStep;
            }
            else
            {
                stepToEdit = LocateItemInListView(e.OriginalSource);
                popup.TestStep = stepToEdit;
            }

            bool? dialogResult = popup.ShowDialog();

            if (dialogResult == true)
            {
                TestStepDefinition step = popup.TestStep;
                TestCase.TestSteps.Add(step);
                testSteps.Items.Refresh();
                latestTestStep = new TestStepDefinition(step); 
                latestTestStep.Action = null;
                latestTestStep.Data = null;
                latestTestStep.Note = null;
                latestTestStep.SaveVariable = false;
                latestTestStep.VariableName = null;
            }
        }

        private void addSharedTestStep_Click(object sender, RoutedEventArgs e)
        {
			AddTestStepArtifact addDialog = new AddTestStepArtifact(_dataManager, TestCase.Name);
			addDialog.Title = "Select shared test steps";
			if (addDialog.ShowDialog() == true)
			{
				List<TestCaseDefinition> testStepsToAdd = addDialog.SelectedTestSteps.Select(item => (TestCaseDefinition)item).ToList();

				foreach (var testStep in testStepsToAdd)
				{
					var tempStep = new TestStepDefinition();
					tempStep.Entity = testStep.Name;
					tempStep.SharedStep = true;
					TestCase.TestSteps.Add(tempStep);
				}

				testSteps.Items.Refresh();
			}
		}

        private void run_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            if (!String.IsNullOrWhiteSpace(TestCase.Name))
            {
                if (TestCase.TestSteps.Count > 0)
                {
                    if (TestCase.Environment.Equals("Production"))
                    {
                        MessageBoxResult result = MessageBox.Show("You have selected to execute this test in the Production environment. Are you sure you want to continue?", "Proceed with execution in Production", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

                        if (result == MessageBoxResult.No)
                            return;
                    }

                    if ((bool)RunInjectionTest.IsChecked && !String.IsNullOrEmpty(RunInjectionTestString.Text))
                            TestCase.InjectionString = RunInjectionTestString.Text;
                        else if (!(bool)RunInjectionTest.IsChecked)
                            TestCase.InjectionString = String.Empty;

                        //if (!(bool)RunInjectionTest.IsChecked)
                        //    TestCase.InjectionString = String.Empty;

                        TestRunner testRunner = ChildPageFactory.CreateTestRunner();
                        testRunner.SetTestToRun(TestCase);
                        LoadChildPage(testRunner);
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Must add at least one test step before running test.", "Test Steps Missing", MessageBoxButton.OK);
                    }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Must provide test name before running test.", "Test Name Missing", MessageBoxButton.OK);
            }
        }
    

        private void InsertStep_Click(object sender, RoutedEventArgs e)
        {
            TestStepDefinition insertStep;
            insertStep = LocateItemInListView(e.OriginalSource);

            int insertIndex = TestCase.TestSteps.IndexOf(insertStep);
            AddEditStepWizard popup = new AddEditStepWizard(_frameworkExaminer, _minderFactory, _dataManager, _configurationProvider);
			popup.TestStep = new TestStepDefinition(insertStep);
			popup.TestStep.Action = null;
            popup.TestStep.Data = null;
            popup.TestStep.Note = null;
            popup.TestStep.SaveVariable = false;
            popup.TestStep.VariableName = null;

			if (!popup.TestStep.SharedStep)
			{
				bool? dialogResult = popup.ShowDialog();

				if (dialogResult == true)
				{
					TestStepDefinition step = popup.TestStep;
					TestCase.TestSteps.Insert(insertIndex + 1, step);
					testSteps.Items.Refresh();
				}
			}
			else
			{
				TestStepDefinition step = popup.TestStep;
				TestCase.TestSteps.Insert(insertIndex + 1, step);
				testSteps.Items.Refresh();
			}
		}

        private void InsertSharedStep_Click(object sender, RoutedEventArgs e)
        {
            TestStepDefinition insertStep;
            insertStep = LocateItemInListView(e.OriginalSource);
            int insertIndex = TestCase.TestSteps.IndexOf(insertStep);

            AddTestStepArtifact addDialog = new AddTestStepArtifact(_dataManager, TestCase.Name);
            addDialog.Title = "Select shared test steps";
            if (addDialog.ShowDialog() == true)
            {
                List<TestCaseDefinition> testStepsToAdd = addDialog.SelectedTestSteps.Select(item => (TestCaseDefinition)item).ToList();

                foreach (var testStep in testStepsToAdd)
                {
                    var tempStep = new TestStepDefinition();
                    tempStep.Entity = testStep.Name;
                    tempStep.SharedStep = true;
                    TestCase.TestSteps.Insert(insertIndex + 1, tempStep);
                    insertIndex++;
                }

                testSteps.Items.Refresh();
            }
        }

        void GridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;

            if (headerClicked != null)
            {
                if (headerClicked.Content.Equals("Delete"))
                {
                    foreach (var testStep in testSteps.Items)
                    {
                        if (!(bool)((KWDT.Core.TestDefinitions.TestStepDefinition)testSteps.Items[testSteps.Items.IndexOf(testStep)]).Delete)
                        {
                            foreach (var step in testSteps.Items)
                            {
                                ((KWDT.Core.TestDefinitions.TestStepDefinition)testSteps.Items[testSteps.Items.IndexOf(step)]).Delete = true;
                            }

                            return;
                        }
                    }

                    foreach (var step in testSteps.Items)
                    {
                        ((KWDT.Core.TestDefinitions.TestStepDefinition)testSteps.Items[testSteps.Items.IndexOf(step)]).Delete = false;
                    }
                }
            }
        }
    }

    public class IntegerToVisibilityMultiConverterForUpArrow : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            System.Collections.IList collection = values[0] as System.Collections.IList;
            object item = values[1];
            if (collection != null && item != null && collection.IndexOf(item) == 0)
                return Visibility.Hidden;

            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IntegerToVisibilityMultiConverterForDownArrow : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            System.Collections.IList collection = values[0] as System.Collections.IList;
            object item = values[1];
            if (collection != null && item != null && collection.IndexOf(item) == collection.Count - 1)
                return Visibility.Hidden;

            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IntegerToVisibilityMultiConverterForBreakpoint : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            System.Collections.IList collection = values[0] as System.Collections.IList;
            object item = values[1];
            if (collection != null && item != null && collection.IndexOf(item) == collection.Count - 1)
                return Visibility.Hidden;

            if (collection != null && item != null && collection.IndexOf(item) == 0)
                return Visibility.Hidden;

            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IntegerToVisibilityMultiConverterForDelete : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            System.Collections.IList collection = values[0] as System.Collections.IList;
            object item = values[1];
            if (collection != null && item != null && collection.IndexOf(item) == collection.Count - 1)
                return Visibility.Visible;

            if (collection != null && item != null && collection.IndexOf(item) == 0)
                return Visibility.Visible;

            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
