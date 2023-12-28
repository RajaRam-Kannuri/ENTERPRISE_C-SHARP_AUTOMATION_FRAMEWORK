using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;

namespace KWDT.Core.TestExecution
{
    public class TestSuiteExecutor : ITestSuiteExecutor
    {
        protected ITestSetExecutor TestSetExecutor { get; set; }

        private IEnumerator<TestSetDefinition> _testSetEnumerator;

        public event EventHandler ProgressNotificationEvent;

        public event EventHandler TestSuiteCompleteEvent;

        public event EventHandler TestSuiteStoppedEvent;

        public event EventHandler TestCaseCompleteEvent;

        public TestSuiteExecutor(IWebDriverSurrogateFactory surrogateFactory)
        {
            TestSetExecutor = new TestSetExecutor(surrogateFactory);
        }

        public void Start(TestSuiteDefinition testSuite)
        {
            _testSetEnumerator = testSuite.TestSets.GetEnumerator();
            RunNextTestSet();
        }

        private void RunNextTestSet()
        {
            if (_testSetEnumerator == null)
                return;

            if (_testSetEnumerator.MoveNext())
            {
                SubscribeToEvents();
                TestSetExecutor.Start(_testSetEnumerator.Current);
            }
            else
                NotifyTestSuiteComplete(this, EventArgs.Empty);
        }

        private void SubscribeToEvents()
        {
            TestSetExecutor.ProgressNotificationEvent += UpdateProgress;
            TestSetExecutor.TestSetCompleteEvent += TestSetComplete;
            TestSetExecutor.TestSetStoppedEvent += TestSetStopped;
            TestSetExecutor.TestCaseCompleteEvent += TestCaseComplete;
        }

        private void UnsubscribeToEvents()
        {
            TestSetExecutor.ProgressNotificationEvent -= UpdateProgress;
            TestSetExecutor.TestSetCompleteEvent -= TestSetComplete;
            TestSetExecutor.TestSetStoppedEvent -= TestSetStopped;
            TestSetExecutor.TestCaseCompleteEvent -= TestCaseComplete;
        }

        public void Pause()
        {
            TestSetExecutor.Pause();
        }

        public void Resume()
        {
            TestSetExecutor.Resume();
        }

        public void Stop()
        {
            TestSetExecutor.Stop();
        }

        public void SingleStep()
        {
            TestSetExecutor.SingleStep();
        }

        public bool IsRunning()
        {
            return TestSetExecutor.IsRunning();
        }

        public bool IsPaused()
        {
            return TestSetExecutor.IsPaused();
        }

        protected void UpdateProgress(object sender, EventArgs e)
        {
            ProgressNotificationEvent?.Invoke(this, e);
        }

        protected void NotifyTestSuiteComplete(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            TestSuiteCompleteEvent?.Invoke(this, e);
        }

        protected void NotifyTestSuiteStopped(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            TestSuiteStoppedEvent?.Invoke(this, e);
        }

        protected void TestSetComplete(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            RunNextTestSet();
        }

        protected void TestSetStopped(object sender, EventArgs e)
        {
            UnsubscribeToEvents();
            NotifyTestSuiteStopped(this, EventArgs.Empty);
        }

        protected void TestCaseComplete(object sender, EventArgs e)
        {
            TestCaseCompleteEvent?.Invoke(this, e);
        }
    }
}
