using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using AutomationFramework;
using KWDT.Core.Configuration;
using KWDT.Core.Interfaces;

namespace PageMinders
{
    public class MinderFactory : IMinderFactory
    {
        private readonly IConfigurationProvider _configProvider;

        public MinderFactory(IConfigurationProvider configProvider)
        {
            if (configProvider == null)
                throw new ArgumentNullException(nameof(configProvider));

            _configProvider = configProvider;
        }

        public PageMinder Create(string programName)
        {
            ProgramConfigurationCollection programConfigurations = _configProvider.GetConfig();

            ProgramConfiguration desiredProgram = programConfigurations.OfType<ProgramConfiguration>().FirstOrDefault(pgm => pgm.DisplayName == programName);

            if (desiredProgram == null)
                throw new ArgumentException("Invalid program: ", programName);

            Type desiredMinderType = GetAvailableMinderTypes().FirstOrDefault(tp => tp.Name == desiredProgram.Type);
            return (PageMinder)Activator.CreateInstance(desiredMinderType, desiredProgram.Url, desiredProgram.BrowserType);
        }

        public Type[] GetAvailableMinderTypes()
        {
            Assembly pageMinderAssembly = AppDomain.CurrentDomain.GetAssemblies().Where(assembly => assembly.FullName.Contains("PageMinders")).FirstOrDefault();
            Type[] minderTypes = pageMinderAssembly.GetTypes().Where(tp => tp.IsSubclassOf(typeof(PageMinder))).ToArray();
            return minderTypes;
        }
    }
}
