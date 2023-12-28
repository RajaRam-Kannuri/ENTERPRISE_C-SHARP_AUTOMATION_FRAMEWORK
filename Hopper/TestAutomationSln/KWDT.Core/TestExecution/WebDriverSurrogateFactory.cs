using System;
using KWDT.Core.Interfaces;

namespace KWDT.Core.TestExecution
{
    public class WebDriverSurrogateFactory : IWebDriverSurrogateFactory
    {
        private readonly IAutomationFrameworkExaminer _frameworkExaminer;

        private readonly IMinderFactory _minderFactory;

        public WebDriverSurrogateFactory(IMinderFactory minderFactory, IAutomationFrameworkExaminer frameworkExaminer)
        {
            if (minderFactory == null)
                throw new ArgumentNullException(nameof(minderFactory));

            _minderFactory = minderFactory;

            if (frameworkExaminer == null)
                throw new ArgumentNullException(nameof(frameworkExaminer));

            _frameworkExaminer = frameworkExaminer;
        }

        public IWebDriverSurrogate Create(string programName)
        {
            return new WebDriverSurrogate(_minderFactory, programName, _frameworkExaminer);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
