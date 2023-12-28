using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using KWDT.Data;
using System.IO;
using OpenQA.Selenium;

namespace KWDT.UI.UserControls
{
    public class CommandLineExecutor
    {
        private readonly IWebDriverSurrogateFactory _surrogateFactory;

        private readonly ITestSuiteExecutor _testSuiteExecutor;

        private readonly IMinderFactory _minderFactory;

        private readonly IAutomationFrameworkExaminer _frameworkExaminer;

        private readonly IDataManager _dataManager;

        private readonly IConfigurationProvider _configurationProvider;

        private BackgroundWorker _executionThread;

        private TestCaseDefinition _testCase;

        private IWebDriverSurrogate webDriverSurrogate;

        private Dictionary<string, IWebDriverSurrogate> surrogates;

        private bool _pause;

        private bool _singleStep;

        private bool _running;

        public event EventHandler ProgressNotificationEvent;

        public event EventHandler TestCaseCompleteEvent;

        public CommandLineExecutor(IWebDriverSurrogateFactory surrogateFactory, IMinderFactory minderFactory, ITestSuiteExecutor testSuiteExecutor, IAutomationFrameworkExaminer frameworkExaminer, IDataManager dataManager, IConfigurationProvider configurationProvider)
        {
            if (surrogateFactory == null)
                throw new ArgumentNullException(nameof(surrogateFactory));

            _surrogateFactory = surrogateFactory;

            if (testSuiteExecutor == null)
                throw new ArgumentNullException(nameof(testSuiteExecutor));

            _testSuiteExecutor = testSuiteExecutor;

            if (minderFactory == null)
                throw new ArgumentNullException(nameof(minderFactory));

            _minderFactory = minderFactory;

            if (frameworkExaminer == null)
                throw new ArgumentNullException(nameof(frameworkExaminer));

            _frameworkExaminer = frameworkExaminer;

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

            if (configurationProvider == null)
                throw new ArgumentNullException(nameof(configurationProvider));

            _configurationProvider = configurationProvider;

            _pause = false;
            _singleStep = false;
            _running = false;
        }

        public void Execute(string[] parameters)
        {
            string testType = parameters[0];
            string filename = parameters[1];

            TestRunner testRunner = new TestRunner(_testSuiteExecutor, _dataManager);
            testRunner.closeOnComplete = true;

            switch (testType)
            {
                case "TestCase":
                    testRunner.SetTestToRun(_dataManager.LoadTestCase(filename));
                        break;
                case "TestSet":
                    testRunner.SetTestToRun(_dataManager.LoadTestSet(filename));
                    break;
                case "TestSuite":
                    testRunner.SetTestToRun(_dataManager.LoadTestSuite(filename));
                    break;
            }

            testRunner.StartNew();
        }
    }
}
