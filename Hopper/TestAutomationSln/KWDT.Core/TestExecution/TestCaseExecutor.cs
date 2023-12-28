using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using System.IO;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace KWDT.Core.TestExecution
{
    public class TestCaseExecutor : ITestCaseExecutor
    {
        private readonly IWebDriverSurrogateFactory _surrogateFactory;

        private BackgroundWorker _executionThread;

        private TestCaseDefinition _testCase;

        private IWebDriverSurrogate webDriverSurrogate;

        private Dictionary<string, IWebDriverSurrogate> surrogates;

        private bool _pause;

        private bool _singleStep;

        private bool _running;

        public event EventHandler ProgressNotificationEvent;

        public event EventHandler TestCaseCompleteEvent;

        public event EventHandler TestCaseStoppedEvent;

        public TestCaseExecutor(IWebDriverSurrogateFactory surrogateFactory)
        {
            if (surrogateFactory == null)
                throw new ArgumentNullException(nameof(surrogateFactory));

            _surrogateFactory = surrogateFactory;

            _pause = false;
            _singleStep = false;
            _running = false;
        }

        public bool IsRunning()
        {
            return _running;
        }

        public bool IsPaused()
        {
            return _pause;
        }

        public void Start(TestCaseDefinition testCase)
        {
            _executionThread = new BackgroundWorker
            {
                WorkerSupportsCancellation = true,
                WorkerReportsProgress = true
            };

            SubscribeToEvents();

            _testCase = testCase;

            if (!_running)
                _executionThread.RunWorkerAsync();
            else
                _pause = false;
        }

        private void SubscribeToEvents()
        {
            _executionThread.DoWork += OnDoWork;
            _executionThread.RunWorkerCompleted += OnRunWorkerCompleted;
            _executionThread.ProgressChanged += OnProgressChanged;
        }

        private void UnsubscribeToEvents()
        {
            _executionThread.DoWork -= OnDoWork;
            _executionThread.RunWorkerCompleted -= OnRunWorkerCompleted;
            _executionThread.ProgressChanged -= OnProgressChanged;
        }

        public void Pause()
        {
            _pause = true;
        }

        public void Resume()
        {
            _pause = false;
        }

        public void Stop()
        {
            _pause = false;
            _running = false;

            if (surrogates != null)
            {
                foreach (IWebDriverSurrogate surrogate in surrogates.Values)
                    surrogate.Dispose();
            }

            if (_executionThread != null)
                _executionThread.CancelAsync();
        }

        public void SingleStep()
        {
            _singleStep = true;
        }

        protected virtual void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressNotificationEvent?.Invoke(this, e);
        }

        protected virtual void OnDoWork(object sender, DoWorkEventArgs e)
        {
            // Get a reference to the worker so we can check for cancellation notices, etc.
            //BackgroundWorker executingThread = sender as BackgroundWorker;
            surrogates = new Dictionary<string, IWebDriverSurrogate>();

            TestResultLogger.CreateTest(_testCase.Name);

            TestStepDefinition runningStep = new TestStepDefinition();

            try
            {
                _running = true;

				List<TestCaseDefinition> savedTestCases = Utilities.LoadAllTestCases();

				TestCaseDefinition updatedTestCase = new TestCaseDefinition(_testCase);

				for (int i = _testCase.TestSteps.Count - 1; i >= 0; i--)
				{
					if (_testCase.TestSteps[i].SharedStep)
					{
						foreach (var savedTestCase in savedTestCases)
						{
							if (_testCase.TestSteps[i].Entity.Equals(savedTestCase.Name))
							{
								updatedTestCase.TestSteps.Remove(updatedTestCase.TestSteps[i]);

							    updatedTestCase.TestSteps.InsertRange(i, savedTestCase.TestSteps);

								break;
							}
						}
					}
				}

				_testCase = updatedTestCase;

				foreach (TestStepDefinition testStep in _testCase.TestSteps)
                {
                    runningStep = testStep;  
                    // Before we do anything for the current step, let's see if we need to cancel.
                    if (_executionThread.CancellationPending)
                    {
                        _running = false;
                        e.Cancel = true;
                        break;
                    }

                    // We also need to see if we are paused, and if the user wants to execute a single step
                    while (_pause && !_singleStep)
                        Thread.Sleep(TimeSpan.FromMilliseconds(100));

                    if (!surrogates.ContainsKey(testStep.Program))
                        surrogates.Add(testStep.Program, _surrogateFactory.Create(testStep.Program));

                    webDriverSurrogate = surrogates[testStep.Program];
                    webDriverSurrogate.Execute(testStep);

                    // Report progress
                    TestCaseExecutionProgress testProgress = new TestCaseExecutionProgress();
                    _executionThread.ReportProgress(1, testProgress);

                    _singleStep = false;
                }
                _running = false;
            }
            catch (Exception E)
            {
                if (!E.Message.Equals("Logged"))
                {
                    TestResultLogger.Fail(E.Message, runningStep.Program, runningStep.Entity);
                }
            }
            finally
            {
                foreach (IWebDriverSurrogate surrogate in surrogates.Values)
                    surrogate.Dispose();
                

                TestResultLogger.CloseReport();
                TestResultLogger.AttachReportToVSTSItem();
                TestResultLogger.CreateTestRunInVSTS();
            }
        }

        protected virtual void OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UnsubscribeToEvents();
            _executionThread.Dispose();
            _pause = false;
            _running = false;
            _singleStep = false;
            TestCaseCompleteEvent?.Invoke(this, e);
        }
    }
}
