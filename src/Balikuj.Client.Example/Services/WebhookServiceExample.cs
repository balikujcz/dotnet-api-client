using Balikuj.Client.Models.Addresses;

namespace Balikuj.Client.Example.Services;

public class WebhookServiceExample
{
    private readonly BalikujClient _client;

    public WebhookServiceExample(BalikujClient client)
    {
        _client = client;

        _client.SetApiKey(ApiRuntimeSettings.ApiKey);
    }

    public async Task RunAsync()
    {
        // Create new webhook
        /*
        Console.WriteLine("Creating new address ...");
        var addressListResult = await _client.AddressCreate(addressCreateRquest);
        Console.WriteLine($"Adress StatusCode = {addressListResult.StatusCode}, id = {addressListResult?.Result?.Id}");
        */

        // Get list of addresses
        /*
        Console.WriteLine("Getting list of addresses ...");
        var addressListResult = await _client.AddressList(new AddressListRequest());
        Console.WriteLine($"AddressList StatusCode = {addressListResult.StatusCode}, items = {addressListResult?.Result?.Data?.Count}");
        */


        // Get list of webhook events
        
        Console.WriteLine("Getting list of webhook events ...");
        var webhookListResult = await _client.WebhookEvents();
        Console.WriteLine($"WebhookList StatusCode = {webhookListResult.StatusCode}, items = {webhookListResult?.Result?.Count}");
        /**/
    }
}
