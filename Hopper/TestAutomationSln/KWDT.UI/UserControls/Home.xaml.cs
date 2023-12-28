using System;
using System.Diagnostics;
using System.Windows;
using KWDT.UI.Factories;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : BaseUserControl
    {
        public Home()
        {
            InitializeComponent();
            ucTitleBar.lblTitle.Content = "Home";
            ucTitleBar.btnBack.Visibility = Visibility.Hidden;
            ucTitleBar.btnHome.Visibility = Visibility.Hidden;
            versionNumber.Content = "Version: 4.2.6";
		}

		private void navTestSuiteList_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            LoadChildPage(ChildPageFactory.CreateTestSuiteList());
        }

        private void navTestSetList_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");
                                                        
            LoadChildPage(ChildPageFactory.CreateTestSetList());
        }

        private void navTestCaseList_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            LoadChildPage(ChildPageFactory.CreateTestCaseList());
        }

        private void navTestResultsList_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            LoadChildPage(ChildPageFactory.CreateTestResultsList());
        }

        private void navLogsList_Click(object sender, RoutedEventArgs e)
        {
            //if (ChildPageFactory == null)
            //    throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            //LoadChildPage(ChildPageFactory.CreateLogsList());

            Process.Start(@"C:\KWDT Temp Repo\Test Results\Logs");
        }

        private void navGlobalVariablesList_Click(object sender, RoutedEventArgs e)
        {
            if (ChildPageFactory == null)
                throw new InvalidOperationException($"{nameof(ChildPageFactory)} is null");

            LoadChildPage(ChildPageFactory.CreateGlobalVariablesList());
        }
    }
}
