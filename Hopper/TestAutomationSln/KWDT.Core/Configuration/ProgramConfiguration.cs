using System.Configuration;
using System.Linq;

namespace KWDT.Core.Configuration
{
    public class ProgramConfiguration : ConfigurationElement
    {
        [ConfigurationProperty("key", IsRequired = true, IsKey = true)]
        public string Key
        {
            get
            {
                return (string)this["key"];
            }
        }

        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }
        }

        [ConfigurationProperty("displayname", IsRequired = true)]
        public string DisplayName
        {
            get
            {
                return (string)this["displayname"];
            }
        }

        //[ConfigurationProperty("url", IsRequired = true)]
        [ConfigurationProperty("url")]
        public string Url
        {
            get
            {
                return (string)this["url"];
            }
        }

        [ConfigurationProperty("browsertype")]
        public string BrowserType
        {
            get
            {
                return (string)this["browsertype"];
            }
        }
    }
    //, DefaultValue = StringConstants.Chrome
    public class ProgramConfigurationCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ProgramConfiguration();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ProgramConfiguration)element).Key;
        }

        public new ProgramConfiguration this[string key]
        {
            get
            {
                return this.OfType<ProgramConfiguration>().FirstOrDefault(pgm => pgm.Key == key);
            }
        }
    }

    public class ProgramConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Programs")]
        [ConfigurationCollection(typeof(ProgramConfigurationCollection))]
        public ProgramConfigurationCollection Programs
        {
            get
            {
                return (ProgramConfigurationCollection)this["Programs"];
            }
        }
    }
}
