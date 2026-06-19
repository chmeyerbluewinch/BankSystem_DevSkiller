
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace BankSystemConfigurationModule.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class StructureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void BankSystemConfigurationModule_StructureTest()
        {            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            PropertyInfo property;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("QmFua1N5c3RlbUNvbmZpZ3VyYXRpb25Nb2R1bGUsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxs") /*"BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("QmFzZUNvbmZpZ3VyYXRpb24=") /*"BaseConfiguration"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration");
                    Assert.IsTrue(type.IsClass, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0Q29uZmlndXJhdGlvbkluZm8=") /*"GetConfigurationInfo"*/ );                            Assert.IsNotNull(method, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.GetConfigurationInfo() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.GetConfigurationInfo() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.GetConfigurationInfo() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("TG9n") /*"Log"*/ );                            Assert.IsNotNull(method, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Log(String log) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Log(String log) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Log(String log) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Log(String log) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("bG9n") /*"log"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Log(String log) parameter log does not exists or does not have type System.String");
                        constructorsCount = type.GetConstructors().Length;
                        Assert.AreEqual(1,constructorsCount, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration constructors count has changed");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("System.Int32");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration(Int32 id) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration(Int32 id)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "constructor: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration(Int32 id) parameter id does not exists or does not have type System.Int32");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(y2=>y2.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SWQ=") /*"Id"*/ );
                            Assert.IsNotNull(property, "property: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Int32 Id does not exists");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Int32 Id  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(y2=>y2.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TGFzdExvZw==") /*"LastLog"*/ );
                            Assert.IsNotNull(property, "property: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.String LastLog does not exists");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.String LastLog  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(y2=>y2.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VW5pcXVlR3VpZA==") /*"UniqueGuid"*/ );
                            Assert.IsNotNull(property, "property: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Guid UniqueGuid does not exists");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Guid",propertyReturnType.FullName, "property: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.BaseConfiguration.Guid UniqueGuid  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJhdGlvbkZhY3Rvcnk=") /*"ConfigurationFactory"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory");
                    Assert.IsTrue(type.IsClass, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory is not class");
                    Assert.IsTrue(type.IsAbstract, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory is not abstract class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory is not public class");
                    Assert.IsTrue(type.IsSealed, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory is not sealed type");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRl") /*"Create"*/ );                            Assert.IsNotNull(method, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory.Create(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory.Create(Int32 id) is not public");
                            Assert.IsTrue(method.IsStatic, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory.Create(Int32 id) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("BankSystemConfigurationModule.IConfiguration",methodReturnType.FullName, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory.Create(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory.Create(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.ConfigurationFactory.Create(Int32 id) parameter id does not exists or does not have type System.Int32");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SUNvbmZpZ3VyYXRpb24=") /*"IConfiguration"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration");
                    Assert.IsTrue(type.IsAbstract, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0Q29uZmlndXJhdGlvbkluZm8=") /*"GetConfigurationInfo"*/ );                            Assert.IsNotNull(method, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.GetConfigurationInfo() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.GetConfigurationInfo() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.GetConfigurationInfo() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("TG9n") /*"Log"*/ );                            Assert.IsNotNull(method, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.Log(String log) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.Log(String log) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.Log(String log) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.Log(String log) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.Log(String log) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.Log(String log) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("bG9n") /*"log"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IConfiguration.Log(String log) parameter log does not exists or does not have type System.String");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SVVzZXJQYXNzd29yZENvbmZpZ3VyYXRpb24=") /*"IUserPasswordConfiguration"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IUserPasswordConfiguration");
                    Assert.IsTrue(type.IsAbstract, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IUserPasswordConfiguration is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IUserPasswordConfiguration is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: BankSystemConfigurationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankSystemConfigurationModule.IUserPasswordConfiguration is not public class");
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
