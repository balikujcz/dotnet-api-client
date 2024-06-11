using Balikuj.Client.Models.Package;
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
            var package = await _client.Package.PackageList();
            Console.WriteLine($"PackageList StatusCode = {package.StatusCode}, items = {package?.Result?.Total}");
            */


            ////////////////////////
            /// Package not ordered info
            /////////////////////////

            /*
            Console.WriteLine("Getting packages ...");
            var package = await _client.Package.NotOrderedInfo();
            Console.WriteLine($"PackageNotOrderedInfo StatusCode = {package.StatusCode}, items = {package?.Result.Count()}");
            */


            ////////////////////////
            /// Package activity
            /////////////////////////
            ///

            /*
            var model = new PackageActivitySearchModel
            {
                Search = "23755010135019"
            };

            Console.WriteLine("Getting packages ...");
            var package = await _client.Package.Activity(model);
            Console.WriteLine($"PackageActivity StatusCode = {package.StatusCode}, items = {package?.Result?.Total}");
            */
        }
    }
}
