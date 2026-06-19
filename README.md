# Banking System Configuration Module

## Introduction
You have to complete the implementation of a banking system module used for managing the configuration parameters.

## Problem Statement

To complete this task, you have to implement the following requirements:
- `IUserPasswordConfiguration` has to expand the `IConfiguration` interface,
- `IUserPasswordConfiguration` has to have a `UserName` property of a `string` type and a `Password` property of a `string` type.
- Create **your custom class** that will implement the `IUserPasswordConfiguration` interface and will inherit from the `BaseConfiguration` class.
- **Your custom class** should have **only one constructor** with one parameter of an `int` type named `id`. The parameter should be passed to the base class constructor.
- **Your custom class** should be protected from inheritance.
- The constructor in the `BaseConfiguration` should set the `Id` property using the value from the `id` parameter.
- The `GetConfigurationInfo` method in the `BaseConfiguration` **should not have ** a default implementation (cannot have body). All classes that inherit from the `BaseConfiguration` should implement it. 
  The compiler should require the implementation of the `GetConfigurationInfo` in children classes. 
- The `GetConfigurationInfo` method in **your custom class** should return the following text: "Configuration id: <value from Id property>; Log: <value from LastLog>" or 
  "Configuration id: <value from Id property>; Log: no log" if the LastLog property is **null** or **empty** or contains only **white-space characters**.
- The `Id` property can be modified only from the `BaseConfiguration`. A read access to the property should be possible from any place that has an instance of the **custom class**.
- The `LastLog` property can be modified only from the `BaseConfiguration` and child classes or by calling the `Log` method from the `BaseConfiguration`. A read access to the property should be possible from any place that has an instance of the **custom class**.
- The access to read the `UniqueGuid` property is allowed only from the `BaseConfiguration`. The access to write is allowed from any place that has an instance of the **custom class**. 
- The ```ConfigurationFactory.Create``` method should create an instance of **your custom class**.

## Hints
1. Follow the TODO comments.
2. Your solution should pass all tests.
