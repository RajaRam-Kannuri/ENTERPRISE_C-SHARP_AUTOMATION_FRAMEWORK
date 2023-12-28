using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using KWDT.Core;


namespace KWDT.UI.UserControls
{
    public partial class AddGlobalVariable : Window
    {
        private readonly IDataManager _dataManager;

        protected GlobalVariableDefinition GlobalVariable { get; set; }

        private List<GlobalVariableDefinition> savedGlobalVariables { get; set; }

        private List<TestCaseDefinition> savedTestCases { get; set; }

        public string tempName { get; set; }

        public string tempValue { get; set; }

        public bool tempSQL { get; set; }

        public string tempSqlScript { get; set; }

		public string tempServer { get; set; }

        public string tempServerUAT { get; set; }

        public string tempServerTraining { get; set; }

        public string tempColumn { get; set; }

        public int tempRow { get; set; } = 1;

		public string tempNote { get; set; }

		public AddGlobalVariable(IDataManager dataManager)
        {
            InitializeComponent();

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

            SetGlobalVariable(new GlobalVariableDefinition());
        }

        public void SetGlobalVariable(GlobalVariableDefinition globalVariable)
        {
            GlobalVariable = globalVariable;
            DataContext = this;
            if (!String.IsNullOrWhiteSpace(globalVariable.Name))
            {
                tempName = GlobalVariable.Name;
                tempValue = GlobalVariable.Value;
                tempSQL = GlobalVariable.UsesSQL;
                tempSqlScript = GlobalVariable.SqlScript;
                tempServer = GlobalVariable.SqlServer;
                tempServerUAT = GlobalVariable.SqlServerUAT;
                tempServerTraining = GlobalVariable.SqlServerTraining;
                tempColumn = GlobalVariable.SqlColumn;
				tempRow = GlobalVariable.SqlRow;
				tempNote = GlobalVariable.Note;
			}

			if (GlobalVariable.UsesSQL)
                setValue.IsEnabled = false;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            String orgName = GlobalVariable.Name;

            if (!String.IsNullOrWhiteSpace(tempName))
            {
                if (Utilities.IsValidFilename(tempName) && !tempName.Contains(" "))
                {
                    savedGlobalVariables = _dataManager.LoadAllGlobalVariables();

                    foreach (var savedGlobalVariable in savedGlobalVariables)
                    {
                        if (savedGlobalVariable.Name.ToLower() == tempName.ToLower() && savedGlobalVariable.VariableID != GlobalVariable.VariableID)
                        {
                            MessageBox.Show("A global variable with that name already exists. Select a new name.", "Duplicate Variable Name", MessageBoxButton.OK);
                            return;
                        }

                        if (savedGlobalVariable.Name != tempName && savedGlobalVariable.VariableID == GlobalVariable.VariableID)
                        {
                            if (!savedGlobalVariables.Exists(x => tempName == x.Name))
                            {
                                _dataManager.Delete(savedGlobalVariable);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("A global variable with that name already exists. Select a new name.", "Duplicate Variable", MessageBoxButton.OK);
                                return;
                            }
                        }
                    }

                    if ((bool)useSQL.IsChecked)
                        tempSQL = true;
                    else
                        tempSQL = false;

                    GlobalVariable.Name = tempName;
                    GlobalVariable.Value = tempValue;
                    GlobalVariable.UsesSQL = tempSQL;
                    GlobalVariable.SqlScript = tempSqlScript;
                    GlobalVariable.SqlColumn = tempColumn;
					GlobalVariable.SqlServer= tempServer;
                    GlobalVariable.SqlServerUAT = tempServerUAT;
                    GlobalVariable.SqlServerTraining = tempServerTraining;
                    GlobalVariable.SqlRow = tempRow;
					GlobalVariable.Note = tempNote;

					if (GlobalVariable.VariableID == 0)
                    {
                        GlobalVariable.VariableID = Utilities.GenerateID();
                    }

                    _dataManager.Save(GlobalVariable);

                    savedTestCases = _dataManager.LoadAllTestCases();

                    //Update all test cases that reference this global variable
                    foreach (var savedTestCase in savedTestCases)
                    {
                        foreach (var testStep in savedTestCase.TestSteps)
                        {
                            if (testStep.Data != null && testStep.Data.Equals("$[" + orgName + "]"))
                            {
                                testStep.Data = "$[" + GlobalVariable.Name + "]";
                                _dataManager.Save(savedTestCase);
                            }

                            if (testStep.SaveVariable == true && (testStep.VariableName.Equals(orgName)))
                            {
                                testStep.VariableName = GlobalVariable.Name;
                                _dataManager.Save(savedTestCase);
                            }
                        }
                    }

                    DialogResult = true;
                    Close();
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Global variable name contains one of the following invalid characters: \\ / : * ? \" < > | or a space", "Invalid Variable Name", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Must provide variable name before saving global variable.", "Variable Name Missing", MessageBoxButton.OK);
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void useSQL_Click(object sender, RoutedEventArgs e)
        {
            enterSQL.IsEnabled = tempSQL;
            SQLScriptLabel.IsEnabled = tempSQL;
			ServerLabel.IsEnabled = tempSQL;
            ServerUATLabel.IsEnabled = tempSQL;
            ServerTrainingLabel.IsEnabled = tempSQL;
            RowLabel.IsEnabled = tempSQL;
            ColumnLabel.IsEnabled = tempSQL;
            setRow.IsEnabled = tempSQL;
			setServer.IsEnabled = tempSQL;
            setServerUAT.IsEnabled = tempSQL;
            setServerTraining.IsEnabled = tempSQL;
            setColumn.IsEnabled = tempSQL;
            setValue.IsEnabled = !tempSQL;
        }
	}
}
