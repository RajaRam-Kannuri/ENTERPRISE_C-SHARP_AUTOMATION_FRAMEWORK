using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using System.Data.SqlClient;
using Spire.Xls;
using System.IO;

namespace KWDT.UI.UserControls
{
	/// <summary>
	/// Interaction logic for GenerateReportWindow.xaml
	/// </summary>
	public partial class GenerateReportWindow : Window
    {
        private readonly IDataManager _dataManager;

        protected List<GlobalVariableDefinition> GlobalVariables { get; set; }

        public List<GlobalVariableDefinition> SelectedGlobalVariables { get; set; }

        public GenerateReportWindow(IDataManager dataManager)
        {
            InitializeComponent();

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

            LoadGlobalVariables();

            globalVariables.ItemsSource = GlobalVariables;

			SelectedGlobalVariables = new List<GlobalVariableDefinition>();

            DataContext = this;

			reportName.Text = "Data Report";
		}

        private void LoadGlobalVariables()
        {
			GlobalVariables = _dataManager.LoadAllGlobalVariables();

			for (int i = GlobalVariables.Count - 1; i >= 0; i--)
			{
				if (!GlobalVariables[i].UsesSQL)
					GlobalVariables.Remove(GlobalVariables[i]);
			}
		}

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

		private void generate_Click(object sender, RoutedEventArgs e)
		{
			var timestamp = DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss");
			string fileName = @"C:\KWDT Temp Repo\Excel Reports\" + reportName.Text + "_" + timestamp + ".xls";

			SqlConnection sqlCon;
			String connectionString;
			int rowCount = 1;

			SelectedGlobalVariables = globalVariables.SelectedItems.OfType<GlobalVariableDefinition>().ToList();

			foreach (var globalVariable in SelectedGlobalVariables)
			{
				if (globalVariable.SqlScript == null)
					continue;

				String sqlCmd = globalVariable.SqlScript.Replace("\r\n", " ");

                if (globalVariable.SqlServer == string.Empty || globalVariable.SqlServer == null)
                    connectionString = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=SUFS";
                else if (globalVariable.SqlServer.Contains("AZ-TC"))
                    connectionString = @"Data Source=.; Trusted_Connection=True; Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=" + globalVariable.SqlServer + "; Database=Epicor102300";
                else
                    connectionString = @"Data Source=.; Trusted_Connection=True; Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=" + globalVariable.SqlServer + "; Database=SUFS";


                using (sqlCon = new SqlConnection(connectionString))
				{
					sqlCon.Open();
					SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd, sqlCon);
					System.Data.DataTable dataTable = new System.Data.DataTable();
					dataAdapter.Fill(dataTable);

					Workbook book = new Workbook();

					if(File.Exists(fileName))
						book.LoadFromFile(fileName);

					if (book.Worksheets.Count > 1)
					{
						for (int i = book.Worksheets.Count - 1; i >= 1; i--)
						{
							book.Worksheets[i].Remove();
						}
					}

					Worksheet sheet = book.Worksheets[0];
					sheet.SetText(rowCount, 1, globalVariable.Name);
					rowCount++;
					sheet.InsertDataTable(dataTable, true, rowCount, 1);
					rowCount += dataTable.Rows.Count + 3;
					book.SaveToFile(fileName);
				}
			}

			if (File.Exists(fileName))
				MessageBox.Show("Report successfully generated!", "Generate Report", MessageBoxButton.OK);
			else
				MessageBox.Show("There was an issue with generating your report.", "Generate Report", MessageBoxButton.OK);
		}
	}
}
