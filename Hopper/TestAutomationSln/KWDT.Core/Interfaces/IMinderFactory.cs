using System;
using AutomationFramework;

namespace KWDT.Core.Interfaces
{
    public interface IMinderFactory
    {
        PageMinder Create(string programName);
        Type[] GetAvailableMinderTypes();
    }
}
