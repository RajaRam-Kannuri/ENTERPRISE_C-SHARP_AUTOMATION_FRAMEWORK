using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for AddTestStepArtifact.xaml
    /// </summary>
    public partial class AddTestStepArtifact : Window
    {
        private readonly IDataManager _dataManager;

        protected List<TestCaseDefinition> SharedTestSteps { get; set; }

        public List<TestCaseDefinition> SelectedTestSteps { get; set; }

        public AddTestStepArtifact(IDataManager dataManager, String name)
        {
            InitializeComponent();

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

            LoadSharedTestSteps(name);

            sharedTestSteps.ItemsSource = SharedTestSteps;

            SelectedTestSteps = new List<TestCaseDefinition>();

            DataContext = this;
        }

        private void LoadSharedTestSteps(String name)
        {
            SharedTestSteps = _dataManager.LoadAllTestCases();

			//foreach (var testCase in SharedTestSteps)
			//{
			//	foreach (var testStep in testCase.TestSteps)
			//	{
			//		if (testStep.SharedStep)
			//			SharedTestSteps.Remove(testCase);
			//	}
			//}

			for (int i = 0; i < SharedTestSteps.Count; i++)
			{
				foreach (var testStep in SharedTestSteps[i].TestSteps)
				{
					if (testStep.SharedStep || SharedTestSteps[i].Name.Equals(name))
					{
						SharedTestSteps.Remove(SharedTestSteps[i]);
						break;
					}
				}
			}
		}

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SelectedTestSteps = sharedTestSteps.SelectedItems.OfType<TestCaseDefinition>().ToList();
            DialogResult = true;
            Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void sharedTestSteps_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DependencyObject dep = (DependencyObject)e.OriginalSource;

            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

			//        if (dep != null)
			//        {
			//TestCaseDefinition tCase = (TestCaseDefinition)sharedTestSteps.ItemContainerGenerator.ItemFromContainer(dep);
			//            SelectedTestSteps.Add(tCase);
			//        }

			//        DialogResult = true;
			//        Close();


			if (dep != null)
			{
				TestCasePreview preview = new TestCasePreview(_dataManager, ((KWDT.Core.TestDefinitions.BaseTestArtifact)((System.Windows.Controls.ContentControl)dep).Content).Name);
				preview.Title = "Test Steps";
				preview.ShowDialog();
			}
		}
    }
}
