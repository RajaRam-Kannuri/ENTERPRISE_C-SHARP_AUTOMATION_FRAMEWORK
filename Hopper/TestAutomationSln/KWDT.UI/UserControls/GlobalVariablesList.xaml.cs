using System;
using System.Collections.Generic;
using System.Windows;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using KWDT.UI.Factories;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Data;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for GlobalVariablesList.xaml
    /// </summary>
    public partial class GlobalVariablesList : EditorPage
    {
        protected List<GlobalVariableDefinition> GlobalVariables { get; set; }
        protected List<GlobalVariableDefinition> FilteredGlobalVariables { get; set; }
        public string globalVariableFilter { get; set; }
        private readonly IDataManager _dataManager;

        public GlobalVariablesList(IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Global Variables";

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;
            UpdateGlobalVariables();
            DataContext = this;
        }

        private void UpdateGlobalVariables()
        {
            variableFilter.Text = "";
            GlobalVariables = _dataManager.LoadAllGlobalVariables();
            globalVariables.ItemsSource = GlobalVariables;
        }

        private void globalVariables_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            GlobalVariableDefinition variableToEdit;
            // int indexToEdit = GlobalVariables.IndexOf(variableToEdit);
            variableToEdit = LocateItemInListView(e.OriginalSource);
            if (variableToEdit != null)
            {
                AddGlobalVariable addDialog = new AddGlobalVariable(_dataManager);
                addDialog.Title = "Edit Global Variable";
                addDialog.SetGlobalVariable(variableToEdit);
                addDialog.ShowDialog();
                UpdateGlobalVariables();
            }
        }

        private GlobalVariableDefinition LocateItemInListView(object source)
        {
            DependencyObject dep = (DependencyObject)source;

            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return null;

            GlobalVariableDefinition variable = (GlobalVariableDefinition)globalVariables.ItemContainerGenerator.ItemFromContainer(dep);
            return variable;
        }

        private void GlobalVariables_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(bool)e.NewValue) return;
        }

        private void SearchGlobalVariable_Click(object sender, RoutedEventArgs e)
        {
            FilteredGlobalVariables = new List<GlobalVariableDefinition>(GlobalVariables);
            int index = 0;

            if (!String.IsNullOrWhiteSpace(globalVariableFilter))
            {
                foreach (GlobalVariableDefinition GlobalVariable in GlobalVariables)
                {
                    if (!GlobalVariable.Name.ToLower().Contains(globalVariableFilter.ToLower()))
                        FilteredGlobalVariables.RemoveAt(index);
                    else
                        index++;
                }
            }

            globalVariables.ItemsSource = FilteredGlobalVariables;
        }

        private void ClearSearchGlobalVariable_Click(object sender, RoutedEventArgs e)
        {
            globalVariableFilter = "";
            variableFilter.Text = "";
            SearchGlobalVariable_Click(sender, e);
        }

        private void globalVariables_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void addGlobalVariable_Click(object sender, RoutedEventArgs e)
        {
            AddGlobalVariable addDialog = new AddGlobalVariable(_dataManager);
            addDialog.Title = "Add New Global Variable";
            if (addDialog.ShowDialog() == true)
            {
                UpdateGlobalVariables();
            }
        }

        private void DeleteVariable_Click(object sender, RoutedEventArgs e)
        {
            if (!ConfirmDelete())
                return;

            GlobalVariableDefinition variableToRemove;

            variableToRemove = LocateItemInListView(e.OriginalSource);
            int indexToRemoveFrom = GlobalVariables.IndexOf(variableToRemove);

            GlobalVariables.RemoveAt(indexToRemoveFrom);
            _dataManager.Delete(variableToRemove);
            UpdateGlobalVariables();
        }

        private void FavoriteVariable_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariableDefinition variableToFavorite;

            variableToFavorite = LocateItemInListView(e.OriginalSource);
            _dataManager.Save(variableToFavorite);
            //UpdateGlobalVariables();
        }

        public class IntegerToVisibilityMultiConverterForFavorite : IMultiValueConverter
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

		private void GenerateReport_Click(object sender, RoutedEventArgs e)
		{
			GenerateReportWindow addDialog = new GenerateReportWindow(_dataManager);
			addDialog.Title = "Select global variables";
			addDialog.ShowDialog();
		}
	}
}





