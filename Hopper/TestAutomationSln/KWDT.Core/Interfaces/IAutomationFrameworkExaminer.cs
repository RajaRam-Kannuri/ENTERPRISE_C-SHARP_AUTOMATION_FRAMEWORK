using System;
using System.Collections.Generic;
using System.Reflection;

namespace KWDT.Core.Interfaces
{
    public interface IAutomationFrameworkExaminer
    {
        Assembly GetAutomationFrameworkAssembly();

        List<MethodInfo> GetKeywordTestingExtensionMethods(string controlTypeName);

        List<Type> GetKeywordTestingTypes();

        List<MethodInfo> GetMethodsByControlType(string controlTypeName);
    }
}