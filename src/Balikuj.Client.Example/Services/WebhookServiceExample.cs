using Balikuj.Client.Models.Webhooks;

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
        //////////////////////
        // Get webhook list
        //////////////////////
        /*
        Console.WriteLine("Creating new address ...");
        var webhook = await _client.WebhookList();
        Console.WriteLine($"Adress StatusCode = {webhook.StatusCode}, count = {webhook?.Result?.Total}");
        */


        /////////////////////////////
        // Get list of webhook events
        /////////////////////////////
        /*
        Console.WriteLine("Getting list of webhook events ...");
        var webhookListResult = await _client.WebhookEvents();
        Console.WriteLine($"WebhookList StatusCode = {webhookListResult.StatusCode}, items = {webhookListResult?.Result?.Count}");
        */

        /////////////////////////////
        /// Webhook get 
        //////////////////////////////
        /*
        int desiredWebhookId = 4;

        Console.WriteLine("Getting webhook  ...");
        var webhook = await _client.WebhookGet(desiredWebhookId);
        Console.WriteLine($"WebhookGet StatusCode = {webhook.StatusCode}, Id = {webhook?.Result?.Id}");
        */

        /////////////////////////////
        /// Webhook create
        //////////////////////////////
        /*
        var webhookCreateModel = new WebhookCreate
        {
            Data = new List<WebhookCreateItemModel>
            {
                new WebhookCreateItemModel
                {
                    Event = "package:delete",
                    Url = "https://www.yourdomain.com/path/continue"
                }
            }
        };
        Console.WriteLine("Creating webhook events ...");
        var webhookCreateResult = await _client.WebhookCreate(webhookCreateModel);
        Console.WriteLine($"WebhookCreate StatusCode = {webhookCreateResult.StatusCode}, items = {webhookCreateResult?.Result?.Webhooks.Count}");
        */


        /////////////////////////////
        /// Webhook update
        ///////////////////////////////
        /*
        var webhookUpdateModel = new WebhookUpdateModel
        {
            Id = 4,
            Url = "https://www.yourdomain.com/path/continue/updated"
        };
        Console.WriteLine("Getting list of webhook events ...");
        var webhookUpdateResult = await _client.WebhookUpdate(webhookUpdateModel);
        Console.WriteLine($"WebhookUpdate StatusCode = {webhookUpdateResult.StatusCode}, result = {webhookUpdateResult?.Result}");
        */


        /////////////////////////////
        /// Webhook delete
        ///////////////////////////////
        /*
        Console.WriteLine("Deleting webhook ...");
        var webhookDeleteResult = await _client.WebhookDelete(4);
        Console.WriteLine($"WebhookUpdate StatusCode = {webhookDeleteResult.StatusCode}, result = {webhookDeleteResult?.Result}");
        */



    }
}
