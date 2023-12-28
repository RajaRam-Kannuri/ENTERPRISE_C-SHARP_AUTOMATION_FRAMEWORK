using System;
using KWDT.Core.TestDefinitions;

namespace KWDT.Core.Interfaces
{
    public interface ITestSuiteExecutor
    {
        void Start(TestSuiteDefinition testSuite);

        void Pause();

        void Resume();

        void Stop();

        void SingleStep();

        bool IsRunning();

        bool IsPaused();

        event EventHandler ProgressNotificationEvent;

        event EventHandler TestSuiteCompleteEvent;

        event EventHandler TestCaseCompleteEvent;

        event EventHandler TestSuiteStoppedEvent;
    }
}
