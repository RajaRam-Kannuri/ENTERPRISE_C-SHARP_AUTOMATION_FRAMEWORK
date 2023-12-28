using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWDT.Core.Interfaces
{
    public interface IWebDriverSurrogateFactory : IDisposable
    {
        IWebDriverSurrogate Create(string programName);
    }
}
