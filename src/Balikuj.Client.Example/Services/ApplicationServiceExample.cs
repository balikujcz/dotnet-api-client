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
            /*
            Console.WriteLine("Creating new application ...");
            var application = await _client.ApplicationList();
            Console.WriteLine($"ApplicationCreate StatusCode = {application.StatusCode}, items = {application?.Result?.Total}");
            */

            ////////////////////////////
            //// application get
            ////////////////////////////
            /*
            int applicationId = 1;

            Console.WriteLine("Getting the application ...");
            var application = await _client.ApplicationGet(applicationId);
            Console.WriteLine($"ApplicationGet StatusCode = {application.StatusCode}");
            */


            ////////////////////////////
            /// Application types
            /// /////////////////////////
            /*
            Console.WriteLine("Getting application types ...");
            var application = await _client.ApplicationTypes();
            Console.WriteLine($"ApplicationCreate StatusCode = {application.StatusCode}, result = {application?.Result}");
            */

            
        }
    }
}
