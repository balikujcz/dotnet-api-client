using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class PackageServiceExample
    {

        private readonly BalikujClient _client;

        public PackageServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            ////////////////////////
            /// Package list
            /////////////////////////
            
            /*
            Console.WriteLine("Getting packages ...");
            var orders = await _client.PackageList();
            Console.WriteLine($"PackageList StatusCode = {orders.StatusCode}, items = {orders?.Result?.Total}");
            */
        }
    }
}
