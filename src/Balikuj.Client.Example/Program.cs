/*
* Copyright (c) 2024 Balíkuj.cz
* http://balikuj.cz
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

using Balikuj.Client.Configuration;
using Balikuj.Client.Example.Services;
using Balikuj.Client.Example.Services.CarrierServices;
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
                services.AddSingleton<OrderServiceExample>();
                services.AddSingleton<PackageServiceExample>();
                services.AddSingleton<PickingServiceExample>();
                services.AddSingleton<PickupServiceExample>();
                services.AddSingleton<PrinterServiceExample>();
                services.AddSingleton<RuleServiceExample>();
                services.AddSingleton<DpdServiceExample>();
            })
            .Build();

        BalikujSettings.ApiBaseUrl = "https://api.balikuj.cz/api";

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
        //await host.Services.GetService<LabelServiceExample>()!.RunAsync();

        // Order example
        //await host.Services.GetService<OrderServiceExample>()!.RunAsync();

        // Package example
        //await host.Services.GetService<PackageServiceExample>()!.RunAsync();

        // Picking example
        //await host.Services.GetService<PickingServiceExample>()!.RunAsync();

        // Pickup example
        //await host.Services.GetService<PickupServiceExample>()!.RunAsync();

        // Printer example
        //await host.Services.GetService<PrinterServiceExample>()!.RunAsync();

        // Rule example
        //await host.Services.GetService<RuleServiceExample>()!.RunAsync();

        // Carrier example - DPD
        //await host.Services.GetService<DpdServiceExample>()!.RunAsync();

        //await host.RunAsync();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
