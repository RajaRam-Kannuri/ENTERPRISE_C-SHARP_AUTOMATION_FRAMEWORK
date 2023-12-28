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
    /// Interaction logic for AddTestArtifact.xaml
    /// </summary>
    public partial class AddTestArtifact : Window
    {
        private readonly IDataManager _dataManager;

        protected List<BaseTestArtifact> AllTestArtifacts { get; set; }

        public List<BaseTestArtifact> SelectedTestArtifacts { get; set; }

        private readonly Type _testArtifactType;

        public AddTestArtifact(IDataManager dataManager, Type testArtifactType)
        {
            InitializeComponent();

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

            if (testArtifactType == null)
                throw new ArgumentNullException(nameof(testArtifactType));

            _testArtifactType = testArtifactType;

            LoadTestArtifacts(testArtifactType);

            testArtifacts.ItemsSource = AllTestArtifacts;

            SelectedTestArtifacts = new List<BaseTestArtifact>();

            DataContext = this;
        }

        private void LoadTestArtifacts(Type testArtifactType)
        {
            if (testArtifactType == typeof(TestCaseDefinition))
            {
                AllTestArtifacts = _dataManager.LoadAllTestCases().Select(elem => (BaseTestArtifact)elem).ToList();
            }
            else if (testArtifactType == typeof(TestSetDefinition))
            {
                AllTestArtifacts = _dataManager.LoadAllTestSets().Select(elem => (BaseTestArtifact)elem).ToList();
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SelectedTestArtifacts = testArtifacts.SelectedItems.OfType<BaseTestArtifact>().ToList();
            DialogResult = true;
            Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        //private void testArtifacts_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    DependencyObject dep = (DependencyObject)e.OriginalSource;

        //    while ((dep != null) && !(dep is ListViewItem))
        //    {
        //        dep = VisualTreeHelper.GetParent(dep);
        //    }

        //    if (dep != null)
        //    {
        //        BaseTestArtifact tCase = (BaseTestArtifact)testArtifacts.ItemContainerGenerator.ItemFromContainer(dep);
        //        SelectedTestArtifacts.Add(tCase);
        //    }

        //    DialogResult = true;
        //    Close();
        //}
    }
}
