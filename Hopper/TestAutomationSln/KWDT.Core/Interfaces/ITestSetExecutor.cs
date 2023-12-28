using System;
using KWDT.Core.TestDefinitions;

namespace KWDT.Core.Interfaces
{
    public interface ITestSetExecutor
    {
        void Start(TestSetDefinition testSet);

        void Pause();

        void Resume();

        void Stop();

        void SingleStep();

        bool IsRunning();

        bool IsPaused();

        event EventHandler ProgressNotificationEvent;

        event EventHandler TestSetCompleteEvent;

        event EventHandler TestSetStoppedEvent;

        event EventHandler TestCaseCompleteEvent;
    }
}
