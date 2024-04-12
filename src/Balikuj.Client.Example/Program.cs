﻿using Balikuj.Client.Configuration;
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

                services.AddSingleton<AddressServiceExample>();
                services.AddSingleton<WebhookServiceExample>();
                services.AddSingleton<ApplicationServiceExample>();
                services.AddSingleton<CarrierServiceExample>();
                services.AddSingleton<EmailAccountServiceExample>();
                services.AddSingleton<EmailTemplateServiceExample>();
                services.AddSingleton<LabelServiceExample>();
            })
            .Build();

        BalikujSettings.ApiBaseUrl = "https://localhost:7104/api";

        // Addresses example
        //await host.Services.GetService<AddressServiceExample>()!.RunAsync();

        // Webhook example
        //await host.Services.GetService<WebhookServiceExample>()!.RunAsync();

        // Application example
        //await host.Services.GetService<ApplicationServiceExample>()!.RunAsync();

        // Carrier example
        //await host.Services.GetService<CarrierServiceExample>()!.RunAsync();

        // Email account example
        //await host.Services.GetService<EmailAccountServiceExample>()!.RunAsync();

        // Email template example
        //await host.Services.GetService<EmailTemplateServiceExample>()!.RunAsync();

        // Label example
        await host.Services.GetService<LabelServiceExample>()!.RunAsync();

        //await host.RunAsync();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
