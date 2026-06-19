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
            var custom = new Custom(id);
            //TODO: create instance of IConfiguration (instance of your class)
            return custom;
        }
    }

    internal sealed class Custom : BaseConfiguration, IUserPasswordConfiguration
    {
        public Custom(int id): base(id)
        {
        }

        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string GetConfigurationInfo()
        {
            if (String.IsNullOrWhiteSpace(LastLog))
            {
                return $"Configuration id: {Id}; Log: no log";
            }
            else
            {
                return $"Configuration id: {Id}; Log: {LastLog}";
            }
        }
    }
}
