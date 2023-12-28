using KWDT.Core.Configuration;

namespace KWDT.Core.Interfaces
{
    public interface IConfigurationProvider
    {
        ProgramConfigurationCollection GetConfig();
    }
}
