using Balikuj.Client.Models.Carrier.Cp;
using Balikuj.Client.Models.Pickup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services.CarrierServices
{
    public class CpServiceExample
    {
        private readonly BalikujClient _client;

        public CpServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            ////////////////
            /// GET 
            ///////////////
            ///

            int id = 1;


            Console.WriteLine("Cp getting data ...");
            var result = await _client.Carrier.Cp.GetAsync<AddPackageCpModel>(id);
            Console.WriteLine($"CpGet StatusCode = {result.StatusCode}, Expires in = {result?.Result}");
        }
    }
}
