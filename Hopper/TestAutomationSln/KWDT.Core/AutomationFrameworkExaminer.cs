using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutomationFramework;
using KWDT.Core;
using KWDT.Core.Interfaces;

namespace KWDT.Core
{
    public class AutomationFrameworkExaminer : IAutomationFrameworkExaminer
    {
        public Assembly GetAutomationFrameworkAssembly()
        {
            List<Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            return assemblies.Where(assembly => assembly.FullName.Contains("AutomationFramework")).FirstOrDefault();
        }

        public List<Type> GetKeywordTestingTypes()
        {
            Assembly automationFramework = GetAutomationFrameworkAssembly();
            return automationFramework.GetTypes().Where(type => type.GetCustomAttributes().Any(attr => attr.ToString().Contains(StringConstants.KeywordTesting))).ToList();
        }

        public List<MethodInfo> GetMethodsByControlType(string controlTypeName)
        {
            var controlType = GetKeywordTestingTypes().Where(type => type.GetCustomAttributes().Any(attr => attr.ToString().Contains(StringConstants.KeywordTesting)) && type.Name == controlTypeName).FirstOrDefault();
            List<MethodInfo> methods = new List<MethodInfo>();
            if (controlType != null)
            {
                var controlMethods = controlType.GetMethods().Where(method => method.GetCustomAttributes().Any(attr => attr.ToString().Contains(StringConstants.KeywordTesting + controlTypeName)));
                var generalMethods = controlType.GetMethods().Where(method => method.CustomAttributes.Any(attr => attr.AttributeType == typeof(KeywordTestingGeneral)));
                var extensionMethods = GetKeywordTestingExtensionMethods(controlTypeName);
                methods.AddRange(controlMethods);
                methods.AddRange(generalMethods);
                methods.AddRange(extensionMethods);
            }
            return methods.OrderBy(method => method.Name).ToList();
        }

        public List<MethodInfo> GetKeywordTestingExtensionMethods(string controlTypeName)
        {
            Assembly automationFramework = GetAutomationFrameworkAssembly();
            var keywordMethods = (from type in automationFramework.GetTypes()
                                  where !type.IsGenericType && !type.IsNested
                                  from method in type.GetMethods(BindingFlags.Static
                                      | BindingFlags.Public | BindingFlags.NonPublic)
                                  where method.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false)
                                  && method.CustomAttributes.Any(attr => attr.ToString().Contains(StringConstants.KeywordTesting + controlTypeName) || attr.AttributeType == typeof(KeywordTestingGeneral))
                                  select method).ToList();
            return keywordMethods;
        }
    }
}
