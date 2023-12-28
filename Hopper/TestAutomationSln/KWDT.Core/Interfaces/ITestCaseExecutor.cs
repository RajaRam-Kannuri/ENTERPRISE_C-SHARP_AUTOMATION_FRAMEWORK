using System;
using KWDT.Core.TestDefinitions;

namespace KWDT.Core.Interfaces
{
    public interface ITestCaseExecutor
    {
        void Start(TestCaseDefinition testCase);

        void Pause();

        void Resume();

        void Stop();

        void SingleStep();

        bool IsRunning();

        bool IsPaused();

        event EventHandler ProgressNotificationEvent;

        event EventHandler TestCaseCompleteEvent;

        event EventHandler TestCaseStoppedEvent;
    }
}
