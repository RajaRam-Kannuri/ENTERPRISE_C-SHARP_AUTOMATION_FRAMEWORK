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

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for ViewVariablesWizard.xaml
    /// </summary>
    public partial class ViewVariablesWizard : Window
    {
        protected List<GlobalVariableDefinition> GlobalVariables { get; set; }
        private readonly IDataManager _dataManager;

        public ViewVariablesWizard(IDataManager dataManager)
        {
            InitializeComponent();

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            UpdateGlobalVariables();
            DataContext = this;
        }

        private void UpdateGlobalVariables()
        {
            GlobalVariables = _dataManager.LoadAllGlobalVariables();
            globalVariables.ItemsSource = GlobalVariables;
        }

        private void cancelAddEdit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        private void variable_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (((KWDT.Core.TestDefinitions.BaseTestArtifact)globalVariables.SelectedItem) != null)
            {
                System.Windows.Clipboard.SetText("$[" + ((KWDT.Core.TestDefinitions.BaseTestArtifact)globalVariables.SelectedItem).Name + "]");
                Close();
            }
        }
    }
}
