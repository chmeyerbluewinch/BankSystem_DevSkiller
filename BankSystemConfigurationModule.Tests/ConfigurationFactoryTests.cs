using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemConfigurationModule.Tests
{
    public class ConfigurationFactoryTests
    {
        [Test]
        public void Create_Test()
        {
            var obj = ConfigurationFactory.Create(10);
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj is IConfiguration);
        }
    }
}
