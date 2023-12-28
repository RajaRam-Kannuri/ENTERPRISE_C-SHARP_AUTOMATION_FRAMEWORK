using System.Configuration;
using KWDT.Core.Interfaces;

namespace KWDT.Core.Configuration
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        private readonly ProgramConfigurationCollection _programConfigurations;

        public ConfigurationProvider()
        {
            _programConfigurations = ((ProgramConfigurationSection)ConfigurationManager.GetSection("SUFSPrograms")).Programs;
        }

        public ProgramConfigurationCollection GetConfig()
        {
            return _programConfigurations;
        }
    }
}
