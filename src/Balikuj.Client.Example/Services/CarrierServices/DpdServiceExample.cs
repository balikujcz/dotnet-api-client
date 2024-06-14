using Balikuj.Client.Models.Carrier;
using Balikuj.Client.Models.Carrier.Base;
using Balikuj.Client.Models.Carrier.Cp;
using Balikuj.Client.Models.Carrier.Dpd;
using Balikuj.Client.Models.Pickup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services.CarrierServices
{
    public class DpdServiceExample
    {
        private readonly BalikujClient _client;

        public DpdServiceExample(BalikujClient client)
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
            /*
            int id = 1;

            Console.WriteLine("Dpd getting data ...");
            var result = await _client.Carrier.Dpd.GetAsync<AddPackageDpdModel>(id);
            Console.WriteLine($"DpdGet StatusCode = {result.StatusCode}, Count = {result?.Result.Count}");
            */


            ////////////////
            /// CREATE
            ///////////////
            ///
            /*
            var model = new List<AddPackageDpdModel>()
            {
                new AddPackageDpdModel()
                {
                    CodCurrency = "CZK",
                    CoverCountry = "CZ",
                    CoverEnabled = false,
                    CoverPhone = null,
                    InsuranceCurrency = null,
                    InsurancePrice = null,
                    PackageNumberCustom = "TS23",
                    PackageNumberOrder = 1,
                    Price = 1000,
                    RecCity = "Zlín",
                    RecCompany = "Company",
                    RecCountry = "CZ",
                    RecEmail = "infonet@test.cz",
                    RecName = "František Hromek",
                    RecPhone = "+420777777777",
                    RecStreet = "Ulice 1",
                    RecZip = "76001",
                    SenderCountry = "CZ",
                    SenderEnabled = false,
                    SenderPhone = null,
                    ServiceType = "Private",
                    Weight = 1
                }
            };

            Console.WriteLine("Dpd creating ...");
            var result = await _client.Carrier.Dpd.CreateAsync<AddPackageDpdModel>(model);
            Console.WriteLine($"DpdCreate StatusCode = {result.StatusCode}, Count = {result?.Result.Count()}");
            */



            ////////////////
            /// ORDER
            ///////////////
            ///
            /*
            var model = new PickupOrderModel()
            {
                Packages = new List<int> { 5, 6, 7 }
            };
            
            Console.WriteLine("Dpd ordering ...");
            var result = await _client.Carrier.Dpd.Order<PickupOrderResultModel>(model);
            Console.WriteLine($"DpdOrder StatusCode = {result.StatusCode}, Count = {result?.Result}");
            */


            ////////////////
            /// CANCEL
            ///////////////
            ///

            /*
            var model = new PackageCancelModel()
            {
                Packages = new List<string> { "23755010135018", "23755010135019" }
            };
            
            Console.WriteLine("Dpd cancelling ...");
            var result = await _client.Carrier.Dpd.Cancel<PackageCancelModel>(model);
            Console.WriteLine($"DpdCancel StatusCode = {result.StatusCode}, Count = {result?.Result}");
            */



            ////////////////
            /// Get Manipulation Units
            ///////////////
            ///

            /*
            Console.WriteLine("Dpd manipulation units ...");
            var result = await _client.Carrier.Dpd.ManipulationUnits();
            Console.WriteLine($"DpdManipulationUnits StatusCode = {result.StatusCode}, Count = {result?.Result.Count()}");
            */


            ////////////////
            /// Get Services
            ///////////////
            ///

            /*
            Console.WriteLine("Dpd getting services ...");
            var result = await _client.Carrier.Dpd.Services();
            Console.WriteLine($"DpdServices StatusCode = {result.StatusCode}, Count = {result?.Result.Count()}");
            */


            ////////////////
            /// Get ServiceCountries
            ///////////////
            ///

            /*
            Console.WriteLine("Dpd getting service countries ...");
            var result = await _client.Carrier.Dpd.ServiceCountries();
            Console.WriteLine($"DpdServiceCountries StatusCode = {result.StatusCode}, Count = {result?.Result.Count()}");
            */



            ////////////////
            /// Get ServiceAddons
            ///////////////
            ///
            /*
            string serviceType = "Classic";

            Console.WriteLine("Dpd getting service addons ...");
            var result = await _client.Carrier.Dpd.ServiceAddons(serviceType);
            Console.WriteLine($"DpdServiceAddons StatusCode = {result.StatusCode}, Count = {result?.Result.Count()}");
            */


            ////////////////
            /// Branches
            ///////////////
            

            /*
            var model = new BranchSearchModel
            {
                BranchType = 0,
                Country = "CZ",
                Name = "Brno",
                ServiceType = "NP",
                SubCarrierId = null
            };
            

            Console.WriteLine("Dpd getting branches ...");
            var result = await _client.Carrier.Dpd.Branches(model);
            Console.WriteLine($"DpdBranches StatusCode = {result.StatusCode}, Count = {result?.Result.Total}");
            */



            ////////////////
            /// Tracking
            ///////////////
            
            /*
            var model = new PackageTrackingStatusRequestModel
            {
                Packages = new List<string> { "23755010135018", "23755010135019" }
            };

            Console.WriteLine("Dpd getting branches ...");
            var result = await _client.Carrier.Dpd.Tracking(model);
            Console.WriteLine($"DpdBranches StatusCode = {result.StatusCode}, Count = {result?.Result.Count()}");
            */

        }
    }
}
