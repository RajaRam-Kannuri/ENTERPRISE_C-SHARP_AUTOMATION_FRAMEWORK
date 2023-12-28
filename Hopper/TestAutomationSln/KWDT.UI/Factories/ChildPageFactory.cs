using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageMinders;
using KWDT.Core.Interfaces;
using KWDT.Core.TestExecution;
using KWDT.UI.UserControls;

namespace KWDT.UI.Factories
{
    public class ChildPageFactory
    {
        private readonly ITestSuiteExecutor _testSuiteExecutor;

        private readonly IMinderFactory _minderFactory;

        private readonly IAutomationFrameworkExaminer _frameworkExaminer;

        private readonly IDataManager _dataManager;

        private readonly IConfigurationProvider _configurationProvider;

        public ChildPageFactory(IMinderFactory minderFactory, ITestSuiteExecutor testSuiteExecutor, IAutomationFrameworkExaminer frameworkExaminer, IDataManager dataManager, IConfigurationProvider configurationProvider)
        {
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
        }

        public TestSuiteList CreateTestSuiteList()
        {
            return new TestSuiteList(_dataManager);
        }

        public TestSetList CreateTestSetList()
        {
            return new TestSetList(_dataManager);
        }

        public TestCaseList CreateTestCaseList()
        {
            return new TestCaseList(_dataManager);
        }

        public TestResultsList CreateTestResultsList()
        {
            return new TestResultsList(_dataManager);
        }

        public LogsList CreateLogsList()
        {
            return new LogsList(_dataManager);
        }

        public GlobalVariablesList CreateGlobalVariablesList()
        {
            return new GlobalVariablesList(_dataManager);
        }

        public TestRunner CreateTestRunner()
        {
            TestResultLogger.CloseReport();
            return new TestRunner(_testSuiteExecutor, _dataManager);
        }

        public TestSuiteEditor CreateTestSuiteEditor()
        {
            return new TestSuiteEditor(_dataManager);
        }

        public TestSetEditor CreateTestSetEditor()
        {
            return new TestSetEditor(_dataManager);
        }

        public TestCaseEditor CreateTestCaseEditor()
        {
            return new TestCaseEditor(_frameworkExaminer, _minderFactory, _dataManager, _configurationProvider);
        }
    }
}
