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

To use the Balíkuj HTTP Client, you need to provide your API key. You can do this by setting the field `Apikey` in Balikuj.Client.Example file **ApiRuntimeSettings.cs** property of the `BalikujHttpClient` class. Here's an example of how to configure the client:

```csharp
public static class ApiRuntimeSettings
{
    public const string ApiKey = "YOURAPIKEY";
}
```

## ✨ Usage

The Balíkuj HTTP Client library provides pre-written methods for all supported endpoints, making it easy to interact with the Balíkuj API. Each API controller has an associated `ServiceExample` file, which demonstrates how to call the methods of the HTTP client. These examples show you how to set the required models, pass IDs, and handle responses. You can find all exmaples in Balikuj.Client.Example "Services" folder.

### Example: Getting a list of applications

Here's a basic example of how to call Application endpoint to get list of applications:

```csharp
using Balikuj.Client.Models.Application;
using System.Text.Json;

namespace Balikuj.Client.Example.Services
{
    public class ApplicationServiceExample
    {
        private readonly BalikujClient _client;

        public ApplicationServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            
            ////////////////////////////
            //// Application list
            ////////////////////////////
            
            Console.WriteLine("Listing application ...");
            var list = await _client.Application.List();
            Console.WriteLine($"ApplicationList StatusCode = {list.StatusCode}, items = {list?.Result?.Total}");
            

        }
    }
}
```

### Running the Example
In your program.cs file, you can then call the `RunAsync` method of the `ApplicationServiceExample` class to execute the example:

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
                services.AddSingleton<ApplicationServiceExample>();
            })
            .Build();

        BalikujSettings.ApiBaseUrl = "https://api.balikuj.cz/api";

        // Application example
        await host.Services.GetService<ApplicationServiceExample>()!.RunAsync();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
```

