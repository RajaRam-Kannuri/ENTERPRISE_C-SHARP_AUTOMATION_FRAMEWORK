using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using KWDT.Core;
using KWDT.Core.Configuration;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using System.Reflection;
using System.Linq;
using System.Windows.Data;
using System.Globalization;
using System.IO;
using AutomationFramework;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for AddEditStepWizard.xaml
    /// </summary>
    public partial class AddEditStepWizard : Window
    {
        private TestStepDefinition _testStepForEditing;

        private List<StepProgram> _pagesByProgram;

        private List<StepControlType> _methodsByControlType;

        private readonly IAutomationFrameworkExaminer _frameworkExaminer;

        private readonly IMinderFactory _minderFactory;

        private readonly IDataManager _dataManager;

        private readonly IConfigurationProvider _configurationProvider;

        private bool Updating;

        public TestStepDefinition TestStep { get; set; }

        public AddEditStepWizard(IAutomationFrameworkExaminer frameworkExaminer, IMinderFactory minderFactory, IDataManager dataManager, IConfigurationProvider _configurationProvider)
        {
            InitializeComponent();

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

            if (_configurationProvider == null)
                throw new ArgumentNullException(nameof(_configurationProvider));

            this._configurationProvider = _configurationProvider;

            CollectPages();
            CollectMethodsByControlType();

            //program.ItemsSource = _dataManager.LoadProgramNames();
            //program.ItemsSource = _programConfigurations.OfType<ProgramConfiguration>().Select(pgm => pgm.DisplayName);

            ProgramConfigurationCollection thing = (ProgramConfigurationCollection)_configurationProvider.GetConfig();
            var otherthing = thing.OfType<ProgramConfiguration>().ToList();
            program.ItemsSource = _configurationProvider.GetConfig();

            Updating = false;
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

            _pagesByProgram.OrderBy(program => program.Name);
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

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);

            if (TestStep != null)
            {
                _testStepForEditing = new TestStepDefinition(TestStep);

                Updating = true;

                ProgramConfiguration pgmToUse = _configurationProvider.GetConfig().OfType<ProgramConfiguration>().First(pgm => pgm.DisplayName == _testStepForEditing.Program);

                // Set up the program combobox
                program.SelectedItem = pgmToUse;

                // Set up the entity combobox
                entity.ItemsSource = _pagesByProgram.First(pgm => pgm.Name == pgmToUse.Type).Pages.Select(pg => pg.Name).ToList().OrderBy(pgName => pgName);
                entity.SelectedItem = _testStepForEditing.Entity;
                entity.IsEnabled = true;

                // Set up the element combobox
                element.ItemsSource = _pagesByProgram.First(pgm => pgm.Name == pgmToUse.Type).Pages.First(pg => pg.Name == _testStepForEditing.Entity).Controls.Select(ctrl => ctrl.Name).ToList().OrderBy(ctrlName => ctrlName); ;
                element.SelectedItem = _testStepForEditing.Element;
                element.IsEnabled = true;

                // Set up the action combobox
                StepControlType ctrlType = _methodsByControlType.First(ctrl => ctrl.Type == _testStepForEditing.ElementType);
                action.ItemsSource = ctrlType.Methods.OrderBy(actName => actName); 
                action.SelectedItem = _testStepForEditing.Action;
                action.IsEnabled = true;

                if (_testStepForEditing.Action != null && _testStepForEditing.Action.Contains("Collect"))
                {
                    saveAsGlobalVariable.IsEnabled = true;
                    globalVariableName.IsEnabled = true;
                }
                else
                {
                    if (_testStepForEditing.Action != null && _testStepForEditing.Action.Equals("SetRandomNumber"))
                    {
                        data.IsEnabled = false;
						data2.IsEnabled = false;
                    }

                    saveAsGlobalVariable.IsEnabled = false;
                    globalVariableName.IsEnabled = false;
                }

                if (_testStepForEditing.Action != null)
                {
                    if (!_testStepForEditing.Action.Equals("SetRandomNumber"))
                    {
                        data.IsEnabled = true;
						data2.IsEnabled = true;
                    }

                    saveAddEdit.IsEnabled = true;
                }

                Updating = false;
            }
            else
                _testStepForEditing = new TestStepDefinition();

            DataContext = _testStepForEditing;
        }

        private void cancelAddEdit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void saveAddEdit_Click(object sender, RoutedEventArgs e)
        {
            var globalVariables = new List<String>();

            _testStepForEditing.Program = ((ProgramConfiguration)program.SelectedItem).DisplayName;

            if (TestStep == null)
            {
                if (_testStepForEditing.SaveVariable == true)
                {
                    if (!String.IsNullOrWhiteSpace(_testStepForEditing.VariableName))
                    {
                        if (Utilities.IsValidFilename(_testStepForEditing.VariableName) && !_testStepForEditing.VariableName.Contains(" "))
                        {

                            //check global variables folder for this variable name, if exists cancel save 
                            foreach (string fileName in Directory.EnumerateFiles(StringConstants.GlobalVariablesFolder))
                            {
                                globalVariables.Add(TrimFileName(fileName));
                            }

                            if (globalVariables.Exists(x => _testStepForEditing.VariableName == x))
                            {
                                MessageBoxResult result = MessageBox.Show("A global variable with that name already exists. Click OK to continue and overwrite the existing variable.", "Overwrite Global Variable?", MessageBoxButton.OKCancel);
                                if (result == MessageBoxResult.Cancel)
                                    return;
                            }
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show("Global variable name contains one of the following invalid characters: \\ / : * ? \" < > | or a space", "Invalid Global Variable Name", MessageBoxButton.OK);
                            return;
                        }
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Must provide global variable name before saving global variable.", "Variable Name Missing", MessageBoxButton.OK);
                        return;
                    }
                }
                else
                {
                    _testStepForEditing.SaveVariable = false;
                    _testStepForEditing.VariableName = "";
                }

                TestStep = _testStepForEditing;
            }
            else
            {
                TestStep.Program = _testStepForEditing.Program;
                TestStep.Entity = _testStepForEditing.Entity;
                TestStep.Element = _testStepForEditing.Element;
                TestStep.ElementType = _testStepForEditing.ElementType;
                TestStep.Action = _testStepForEditing.Action;
                TestStep.Data = _testStepForEditing.Data;
				TestStep.Data2 = _testStepForEditing.Data2;
				TestStep.Note = _testStepForEditing.Note;
                TestStep.SharedStep = _testStepForEditing.SharedStep;

                if (_testStepForEditing.SaveVariable == true)
                {
                    if (!String.IsNullOrWhiteSpace(_testStepForEditing.VariableName))
                    {
                        if (Utilities.IsValidFilename(_testStepForEditing.VariableName) && !_testStepForEditing.VariableName.Contains(" "))
                        {

                            //check global variables folder for this variable name, if exists cancel save 
                            foreach (string fileName in Directory.EnumerateFiles(StringConstants.GlobalVariablesFolder))
                            {
                                globalVariables.Add(TrimFileName(fileName));
                            }

                            if (globalVariables.Exists(x => _testStepForEditing.VariableName == x))
                            {
                                MessageBoxResult result = MessageBox.Show("A global variable with that name already exists. Click OK to continue and overwrite the existing variable.", "Overwrite Global Variable?", MessageBoxButton.OKCancel);
                                if (result == MessageBoxResult.Cancel)
                                    return;
                            }
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show("Global variable name contains one of the following invalid characters: \\ / : * ? \" < > | or a space", "Invalid Global Variable Name", MessageBoxButton.OK);
                            return;
                        }
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Must provide global variable name before saving global variable.", "Variable Name Missing", MessageBoxButton.OK);
                        return;
                    }

                    TestStep.SaveVariable = _testStepForEditing.SaveVariable;
                    TestStep.VariableName = _testStepForEditing.VariableName;
                }
                else
                {
                    TestStep.SaveVariable = false;
                    TestStep.VariableName = "";
                }
            }

            DialogResult = true;
            Close();
        }

        public String TrimFileName(String fileName)
        {
            string[] subString = fileName.Split('\\');
            string newSubString = subString[3];
            string newFileName = newSubString.Replace(".json", "");
            return newFileName;
        }

        private void program_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (Updating == false)
            {
                Updating = true;
                ProgramConfiguration selectedProgram = (ProgramConfiguration)program.SelectedItem;

                // Set the available pages for the selected program
                entity.SelectedItem = null;
                entity.ItemsSource = _pagesByProgram.First(pgm => pgm.Name == selectedProgram.Type).Pages.Select(pg => pg.Name).ToList().OrderBy(pgName => pgName);
                entity.IsEnabled = true;

                // Clear and disable the remaining controls
                element.SelectedItem = null;
                element.ItemsSource = null;
                element.IsEnabled = false;

                action.SelectedItem = null;
                action.ItemsSource = null;
                action.IsEnabled = false;

                _testStepForEditing.Data = string.Empty;
                data.IsEnabled = false;

				_testStepForEditing.Data2 = string.Empty;
				data2.IsEnabled = false;

                _testStepForEditing.SaveVariable = false;
                saveAsGlobalVariable.IsEnabled = false;

                _testStepForEditing.VariableName = string.Empty;
                globalVariableName.IsEnabled = false;

                saveAddEdit.IsEnabled = false;

                Updating = false;
            }
        }

        private void entity_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (Updating == false)
            {
                Updating = true;
                ProgramConfiguration selectedProgram = (ProgramConfiguration)program.SelectedItem;
                string selectedPage = entity.SelectedItem.ToString();

                // Set the available elements for the selected page
                element.SelectedItem = null;
                element.ItemsSource = _pagesByProgram.First(pgm => pgm.Name == selectedProgram.Type).Pages.First(pg => pg.Name == selectedPage).Controls.Select(ctrl => ctrl.Name).ToList().OrderBy(ctrlName => ctrlName);
                element.IsEnabled = true;

                // Clear and disable the remaining controls
                action.SelectedItem = null;
                action.ItemsSource = null;
                action.IsEnabled = false;

                _testStepForEditing.Data = string.Empty;
                data.IsEnabled = false;

				_testStepForEditing.Data2 = string.Empty;
				data2.IsEnabled = false;

                _testStepForEditing.SaveVariable = false;
                saveAsGlobalVariable.IsEnabled = false;

                _testStepForEditing.VariableName = string.Empty;
                globalVariableName.IsEnabled = false;

                saveAddEdit.IsEnabled = false;

                Updating = false;
            }
        }

        private void element_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (Updating == false)
            {
                Updating = true;
                ProgramConfiguration selectedProgram = (ProgramConfiguration)program.SelectedItem;
                string selectedPage = entity.SelectedItem.ToString();
                string selectedControl = element.SelectedItem.ToString();
                string selectedControlType = _pagesByProgram.First(pgm => pgm.Name == selectedProgram.Type).Pages.First(pg => pg.Name == selectedPage).Controls.First(ctrl => ctrl.Name == selectedControl).Type;
                StepControlType ctrlType = _methodsByControlType.First(ctrl => ctrl.Type == selectedControlType);
                _testStepForEditing.ElementType = ctrlType.Type;

                // Set the available actions for the selected element type
                action.SelectedItem = null;
                action.ItemsSource = ctrlType.Methods;
                action.IsEnabled = true;

                // Clear and disable the remaining controls
                _testStepForEditing.Data = string.Empty;
                data.IsEnabled = false;

				_testStepForEditing.Data2 = string.Empty;
				data2.IsEnabled = false;

                _testStepForEditing.SaveVariable = false;
                saveAsGlobalVariable.IsEnabled = false;

                _testStepForEditing.VariableName = string.Empty;
                globalVariableName.IsEnabled = false;

                saveAddEdit.IsEnabled = false;

                Updating = false;
            }
        }

        private void action_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (Updating == false)
            {
                Updating = true;

                // Get rid of the old data value
                _testStepForEditing.Data = string.Empty;
                data.IsEnabled = true;

				_testStepForEditing.Data2 = string.Empty;
				data2.IsEnabled = true;

                _testStepForEditing.SaveVariable = false;
                saveAsGlobalVariable.IsEnabled = false;

                _testStepForEditing.VariableName = string.Empty;
                globalVariableName.IsEnabled = false;

                if (_testStepForEditing.Action != null && _testStepForEditing.Action.Contains("Collect"))
                {
                    saveAsGlobalVariable.IsEnabled = true;
                    globalVariableName.IsEnabled = true;
                }
                else
                {
                    if (_testStepForEditing.Action != null && _testStepForEditing.Action.Equals("SetRandomNumber"))
                    {
                        data.IsEnabled = false;
						data2.IsEnabled = false;
                    }
                    saveAsGlobalVariable.IsEnabled = false;
                    globalVariableName.IsEnabled = false;
                }
                // Allow saving at this point
                saveAddEdit.IsEnabled = true;

                Updating = false;
            }
        }

        private void viewVariables_Click(object sender, RoutedEventArgs e)
        {
            ViewVariablesWizard popup = new ViewVariablesWizard(_dataManager);
            bool? dialogResult = popup.ShowDialog();
        }
    }
}
