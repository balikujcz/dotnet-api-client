using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class PickupServiceExample
    {
        private readonly BalikujClient _client;

        public PickupServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            ////////////////////
            /// Pickup List
            ////////////////////

            /*
            Console.WriteLine("Getting pickup list  ...");
            var pickup = await _client.Pickup.List();
            Console.WriteLine($"PickupList StatusCode = {pickup.StatusCode}, Items = {pickup?.Result?.Total}");
            */
        }
    }
}
