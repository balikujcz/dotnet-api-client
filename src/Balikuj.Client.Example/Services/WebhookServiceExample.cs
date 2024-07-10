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


using Balikuj.Client.Models.Webhooks;

namespace Balikuj.Client.Example.Services;

public class WebhookServiceExample
{
    private readonly BalikujClient _client;

    public WebhookServiceExample(BalikujClient client)
    {
        _client = client;
    }

    public async Task RunAsync()
    {
        //////////////////////
        // Get webhook list
        //////////////////////
        
        Console.WriteLine("Creating new address ...");
        var webhook = await _client.Webhook.List();
        Console.WriteLine($"Adress StatusCode = {webhook.StatusCode}, count = {webhook?.Result?.Total}");
        

        /////////////////////////////
        // Get list of webhook events
        /////////////////////////////
        
        Console.WriteLine("Getting list of webhook events ...");
        var webhookListResult = await _client.Webhook.Events();
        Console.WriteLine($"WebhookList StatusCode = {webhookListResult.StatusCode}, items = {webhookListResult?.Result?.Count}");
        

        /////////////////////////////
        /// Webhook get 
        //////////////////////////////
        
        int desiredWebhookId = 4;

        Console.WriteLine("Getting webhook  ...");
        var webhookGet = await _client.Webhook.Get(desiredWebhookId);
        Console.WriteLine($"WebhookGet StatusCode = {webhookGet.StatusCode}, Id = {webhookGet?.Result?.Id}");
        

        //////////////////////
        /// Webhook create
        //////////////////////
        
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
        var webhookCreateResult = await _client.Webhook.Create(webhookCreateModel);
        Console.WriteLine($"WebhookCreate StatusCode = {webhookCreateResult.StatusCode}, items = {webhookCreateResult?.Result?.Webhooks.Count}");
        


        /////////////////////////////
        /// Webhook update
        ///////////////////////////////
        
        var webhookUpdateModel = new WebhookUpdateModel
        {
            Id = 4,
            Url = "https://www.yourdomain.com/path/continue/updated"
        };
        Console.WriteLine("Getting list of webhook events ...");
        var webhookUpdateResult = await _client.Webhook.Update(webhookUpdateModel);
        Console.WriteLine($"WebhookUpdate StatusCode = {webhookUpdateResult.StatusCode}, result = {webhookUpdateResult?.Result}");
        


        /////////////////////////////
        /// Webhook delete
        ///////////////////////////////
        
        Console.WriteLine("Deleting webhook ...");
        var webhookDeleteResult = await _client.Webhook.Delete(4);
        Console.WriteLine($"WebhookUpdate StatusCode = {webhookDeleteResult.StatusCode}, result = {webhookDeleteResult?.Result}");
        



    }
}
