using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using KWDT.Core.TestExecution;

namespace KWDT.Core.TestExecution
{
    public class TestSetExecutor : ITestSetExecutor
    {
        protected ITestCaseExecutor TestCaseExecutor { get; set; }

        private IEnumerator<TestCaseDefinition> _testCaseEnumerator;

        public event EventHandler ProgressNotificationEvent;

        public event EventHandler TestSetCompleteEvent;

        public event EventHandler TestSetStoppedEvent;

        public event EventHandler TestCaseCompleteEvent;

        public TestSetExecutor(IWebDriverSurrogateFactory surrogateFactory)
        {
            TestCaseExecutor = new TestCaseExecutor(surrogateFactory);
        }

        public void Start(TestSetDefinition testSet)
        {
            _testCaseEnumerator = testSet.TestCases.GetEnumerator();
            TestResultLogger.SetTestSetName(testSet.Name);
            //SubscribeToEvents();
            RunNextTestCase();
        }

        private void RunNextTestCase()
        {
            if (_testCaseEnumerator == null)
                return;

            if (_testCaseEnumerator.MoveNext())
            {
                SubscribeToEvents();
                TestCaseExecutor.Start(_testCaseEnumerator.Current);
            }
            else
                NotifyTestSetComplete(this, EventArgs.Empty);
        }

        private void SubscribeToEvents()
        {
            TestCaseExecutor.ProgressNotificationEvent += UpdateProgress;
            TestCaseExecutor.TestCaseCompleteEvent += TestCaseComplete;
            TestCaseExecutor.TestCaseStoppedEvent += TestCaseStopped;
        }

        private void UnsubscribeToEvents()
        {
            TestCaseExecutor.ProgressNotificationEvent -= UpdateProgress;
            TestCaseExecutor.TestCaseCompleteEvent -= TestCaseComplete;
            TestCaseExecutor.TestCaseStoppedEvent -= TestCaseStopped;
        }

        public void Pause()
        {
            TestCaseExecutor.Pause();
        }

        public void Resume()
        {
            TestCaseExecutor.Resume();
        }

        public void Stop()
        {
            TestCaseExecutor.Stop();
        }

        public void SingleStep()
        {
            TestCaseExecutor.SingleStep();
        }

        public bool IsRunning()
        {
            return TestCaseExecutor.IsRunning();
        }

        public bool IsPaused()
        {
            return TestCaseExecutor.IsPaused();
        }

        protected void UpdateProgress(object sender, EventArgs e)
        {
            ProgressNotificationEvent?.Invoke(this, e);
        }

        protected void NotifyTestSetComplete(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            TestSetCompleteEvent?.Invoke(this, e);
        }

        protected void NotifyTestSetStopped(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            TestSetStoppedEvent?.Invoke(this, e);
        }

        protected void TestCaseComplete(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            //update here for stop logic
            TestCaseCompleteEvent?.Invoke(this, e);
            //if(TestCaseExecutor.IsPaused())
            RunNextTestCase();
        }

        protected void TestCaseStopped(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            NotifyTestSetStopped(this, EventArgs.Empty);
        }
    }
}
