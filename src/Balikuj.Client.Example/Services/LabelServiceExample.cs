using Balikuj.Client.Models.Label;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class LabelServiceExample
    {
        private readonly BalikujClient _client;

        public LabelServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            /////////////////////////
            /// Label not printed
            /// /////////////////////

            var enumType = LabelType.Zpl;

            Console.WriteLine("Getting not printed labels accounts ...");
            var notPrinted = await _client.LabelNotPrinted(enumType);
            Console.WriteLine($"LabelNotPrinted StatusCode = {notPrinted.StatusCode}, Count = {notPrinted?.Result?.Count}");
        }
    }
}
