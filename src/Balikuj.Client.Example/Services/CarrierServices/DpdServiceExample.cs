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
                Date = DateTime.Now.AddDays(2).ToString(),
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
            
            var model = new PackageCancelModel()
            {
                Packages = new List<string> { "23755010135025", "23755010135026" }
            };

            Console.WriteLine("Dpd ordering ...");
            var result = await _client.Carrier.Dpd.Cancel<PackageCancelModel>(model);
            Console.WriteLine($"DpdOrder StatusCode = {result.StatusCode}, Count = {result?.Result}");
            
            




        }
    }
}
