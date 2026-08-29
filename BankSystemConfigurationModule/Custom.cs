using System;

namespace BankSystemConfigurationModule
{
    public sealed class Custom : BaseConfiguration, IUserPasswordConfiguration
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Custom(int id) : base(id)
        {
        }

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
