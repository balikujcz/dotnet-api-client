using Balikuj.Client.Models.Carrier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class CarrierServiceExample
    {
        private readonly BalikujClient _client;

        public CarrierServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {

            /////////////////////////
            /// Carrier List
            ///////////////////////// 
            /*
            Console.WriteLine("Getting carriers ...");
            var carrier = await _client.CarrierList();
            Console.WriteLine($"CarrierList StatusCode = {carrier.StatusCode}, result = {carrier?.Result?.ToList().Count}");
            */

            /////////////////////////
            /// Carrier service list
            ///////////////////////// 
            /*
            var serviceSearch = new CarrierServiceSearchModel
            {
                 CarrierCode = "PPL"
            };

            Console.WriteLine("Getting carriers services ...");
            var carrierServices = await _client.CarrierServices(serviceSearch);
            Console.WriteLine($"CarrierList StatusCode = {carrierServices.StatusCode}, items = {carrierServices?.Result?.ToList().Count}");
            */

            //////////////////////////////
            /// Carrier Manipulation Units
            /////////////////////////////
            ///
            /*
            var manipulationSearch = new CarrierManipulationUnitSearchModel
            {
                CarrierCode = "GEIS"
            };

            Console.WriteLine("Getting carrier manipulation units ...");
            var manipulationUnits = await _client.CarrierManipulation(manipulationSearch);
            Console.WriteLine($"CarrierManipulationUnits StatusCode = {manipulationUnits.StatusCode}, items = {manipulationUnits?.Result?.Count()}");
            */
        }
    }
}
