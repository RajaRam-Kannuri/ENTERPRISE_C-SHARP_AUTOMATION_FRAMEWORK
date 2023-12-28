using System.Windows;
using KWDT.Core;
using KWDT.Core.Configuration;
using KWDT.Core.TestExecution;
using KWDT.Data;
using KWDT.UI.Factories;
using KWDT.UI.UserControls;
using PageMinders;
using System;
using System.Threading;

namespace KWDT.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ConfigurationProvider configProvider = new ConfigurationProvider();
            DataManger dataManager = new DataManger();
            AutomationFrameworkExaminer frameworkExaminer = new AutomationFrameworkExaminer();
            MinderFactory minderFactory = new MinderFactory(configProvider);
            WebDriverSurrogateFactory surrogateFactory = new WebDriverSurrogateFactory(minderFactory, frameworkExaminer);
            TestSuiteExecutor testSuiteExecutor = new TestSuiteExecutor(surrogateFactory);
            CommandLineExecutor commandLineExecutor = new CommandLineExecutor(surrogateFactory, minderFactory, testSuiteExecutor, frameworkExaminer, dataManager, configProvider);

            if (e.Args.Length != 2)
            {
                MainWindow mainWindow = new MainWindow(new ChildPageFactory(minderFactory, testSuiteExecutor, frameworkExaminer, dataManager, configProvider));
                mainWindow.Show();
            }
            else
            {
                commandLineExecutor.Execute(e.Args);
                KWDT.Core.Utilities.SetExecutedByCommandLine(true);
            }
        }
    }
}
