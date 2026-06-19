using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemConfigurationModule
{
    public static class ConfigurationFactory
    {
        public static IConfiguration Create(int id)
        {
            var custon = new Custom(id);
            //TODO: create instance of IConfiguration (instance of your class)
            return null;
        }
    }

    protected class Custom : BaseConfiguration, IUserPasswordConfiguration
    {
        Custom(int id): base(id)
        {
        }

        public override string GetConfigurationInfo()
        {
            if (String.IsNullOrEmpty(LastLog))  // or contains only white-spaces!
            {
                return ("Configuration id: ; Log: no log");
            }
            else
            {
                return ("Configuration id: ; Log: ");
            }
        }
    }
}
