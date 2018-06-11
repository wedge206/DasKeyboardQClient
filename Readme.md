# DasKeyboard QClient.NET
![Build status](https://img.shields.io/appveyor/ci/wedge206/daskeyboardqclient.svg)
[![NuGet](https://img.shields.io/nuget/v/DasKeyboardQClient.svg)](https://www.nuget.org/packages/DasKeyboardQClient)

.Net Framework Client for DasKeyboard Q API
Simple, lightweight, and easy to use.

## Usage
### Create a Local Client
Note: Limited endpoints available on local client
```c#
var client = new LocalQClient();
```

You can also optionally specify a custom hostname and/or custom port number:
```c#
var client = new LocalQClient("myhostname", 27302);
```

### Create an Authenticated Cloud Client
All authentication and token handling is automatic
```c#
var client = new CloudQClient("CLIENTID", "SECRET");
```

### Create an UnAuthenticated Cloud Client
Note: Limited endpoints available when not authenticated
```c#
var client = new CloudQClient();
```