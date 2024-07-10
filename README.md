# Balíkuj HTTP Client

Balíkuj HTTP Client is a .NET library designed to simplify interaction with the Balíkuj API. It includes all models required for API manipulation, pre-written methods for all supported endpoints, and easy configuration for API keys and basic settings.

## Table of Contents

- [Introduction](#introduction)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)

## ✨ Introduction

Balíkuj HTTP Client provides a convenient way to interact with the Balíkuj API, offering predefined models and methods for all supported endpoints. This library is built with .NET, making it easy to integrate into your .NET applications.

## ✨ Installation

To install the Balíkuj HTTP Client, you can use the NuGet package manager. Run the following command in your project directory:

```sh
dotnet add package BalikujHttpClient
```

## ✨ Configuration

To use the Balíkuj HTTP Client, you need to provide your API key. To receive an API key perform a login request to the Balíkuj API as in example below.
To set a new API key, you can use the `SetApiKey` method of the `BalikujClient` class. This method will set the API key across the client.


## ✨ Usage

The Balíkuj HTTP Client library provides pre-written methods for all supported endpoints, making it easy to interact with the Balíkuj API. Each API controller has an associated `ServiceExample` file, 
which demonstrates how to call the methods of the HTTP client. These examples show you how to set the required models, pass IDs, and handle responses. You can find all exmaples in Balikuj.Client.Example "Services" folder.

### Example: Logging in and receiving an API key

Here's a basic example of how to call Account endpoint to log in and receive an API key:

```csharp
using Balikuj.Client.Models.Account;
using System.Net;

namespace Balikuj.Client.Example.Services
{
    public class AccountServiceExample
    {
        private readonly BalikujClient _client;

        public AccountServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {

            //////////////////
            /// Account Login
            //////////////////
            
            
            var loginModel = new AccountLoginRequest
            {
                Email = "info@email.cz",
                Password = "pass",
                Language = "cs-CZ",
                Code = null
            };


            Console.WriteLine("Logging in ...");
            var accountLogin = await _client.Account.LoginAsync(loginModel);
            Console.WriteLine($"Login StatusCode = {accountLogin.StatusCode}, Expires in = {accountLogin?.Result.ExpiresIn}");

            if (accountLogin?.StatusCode == (int)HttpStatusCode.OK)
            {
                Console.WriteLine($"AuthToken = {accountLogin?.Result.AuthToken}");
                _client.SetApiKey(accountLogin?.Result.AuthToken);
            }
           
        }

    }
}
```



### Running the Example
In your program.cs file, you can then call the `RunAsync` method of the `AccountServiceExample` class to execute the example:

```csharp
using Balikuj.Client.Configuration;
using Balikuj.Client.Example.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Balikuj.Client.Example;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args);

        IHost host = builder
            .ConfigureServices(services =>
            {
                services.AddHttpClient<BalikujClient>();
                services.AddSingleton<AccountServiceExample>();
            })
            .Build();

        BalikujSettings.ApiBaseUrl = "https://api.balikuj.cz/api";

        // Account example
        await host.Services.GetService<AccountServiceExample>()!.RunAsync();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
```

