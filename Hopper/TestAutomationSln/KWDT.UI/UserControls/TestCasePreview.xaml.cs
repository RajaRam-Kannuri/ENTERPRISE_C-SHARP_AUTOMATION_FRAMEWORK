using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using AutomationFramework;

namespace KWDT.UI.UserControls
{
	/// <summary>
	/// Interaction logic for TestCasePreview.xaml
	/// </summary>
	public partial class TestCasePreview : Window
    {
        private readonly IDataManager _dataManager;

		protected List<TestStepDefinition> testSteps { get; set; }

        public TestCasePreview(IDataManager dataManager, String name)
        {
            InitializeComponent();

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

			LoadTestSteps(name);

			testRunName.Text = name;

			sharedTestSteps.ItemsSource = testSteps;

            DataContext = this;
        }

        private void LoadTestSteps(String name)
        {
            try
            {
                var testCase = _dataManager.LoadTestCase(StringConstants.TestCaseFolder + name + ".json");
                testSteps = testCase.TestSteps;
            }
            catch { }
		}
    }
}
