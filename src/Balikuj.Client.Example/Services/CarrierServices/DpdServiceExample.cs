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

using Balikuj.Client.Models.Carrier;
using Balikuj.Client.Models.Carrier.Base;
using Balikuj.Client.Models.Carrier.Dpd;
using Balikuj.Client.Models.Pickup;

namespace Balikuj.Client.Example.Services.CarrierServices
{
    public class DpdServiceExample
    {
        private readonly BalikujClient _client;

        public DpdServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {
            ////////////////
            /// GET 
            ///////////////
            
            
            int id = 1;

            Console.WriteLine("Dpd getting data ...");
            var result = await _client.Carrier.Dpd.GetAsync<AddPackageDpdModel>(id);
            Console.WriteLine($"DpdGet StatusCode = {result.StatusCode}, Count = {result?.Result.Count}");
            

            
            ////////////////
            /// CREATE
            ///////////////
            
            
            var createModel = new List<AddPackageDpdModel>()
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
            var createResult = await _client.Carrier.Dpd.CreateAsync<AddPackageDpdModel>(createModel);
            Console.WriteLine($"DpdCreate StatusCode = {createResult.StatusCode}, Count = {createResult?.Result.Count()}");
            



            ////////////////
            /// ORDER
            ///////////////
            
            
            var orderModel = new PickupOrderModel()
            {
                Packages = new List<int> { 5, 6, 7 }
            };
            
            Console.WriteLine("Dpd ordering ...");
            var orderResult = await _client.Carrier.Dpd.Order<PickupOrderResultModel>(orderModel);
            Console.WriteLine($"DpdOrder StatusCode = {orderResult.StatusCode}, Count = {orderResult?.Result}");
            


            ////////////////
            /// CANCEL
            ///////////////
            
      
            var model = new PackageCancelModel()
            {
                Packages = new List<string> { "23755010135018", "23755010135019" }
            };
            
            Console.WriteLine("Dpd cancelling ...");
            var cancelResult = await _client.Carrier.Dpd.Cancel<PackageCancelModel>(model);
            Console.WriteLine($"DpdCancel StatusCode = {cancelResult.StatusCode}, Count = {cancelResult.Result?.Count()}");
            



            //////////////////////////
            /// Get Manipulation Units
            /////////////////////////
            

            Console.WriteLine("Dpd manipulation units ...");
            var manipulationUnitsResult = await _client.Carrier.Dpd.ManipulationUnits();
            Console.WriteLine($"DpdManipulationUnits StatusCode = {manipulationUnitsResult.StatusCode}, Count = {manipulationUnitsResult?.Result.Count()}");
            


            ////////////////
            /// Get Services
            ///////////////
   
    
            Console.WriteLine("Dpd getting services ...");
            var servicesResult = await _client.Carrier.Dpd.Services();
            Console.WriteLine($"DpdServices StatusCode = {servicesResult.StatusCode}, Count = {servicesResult?.Result.Count()}");
            


            ////////////////
            /// Get ServiceCountries
            ///////////////

            
            Console.WriteLine("Dpd getting service countries ...");
            var serviceCountriesResult = await _client.Carrier.Dpd.ServiceCountries();
            Console.WriteLine($"DpdServiceCountries StatusCode = {serviceCountriesResult.StatusCode}, Count = {serviceCountriesResult?.Result.Count()}");
            



            ////////////////
            /// Get ServiceAddons
            ///////////////
            

            string serviceType = "Classic";

            Console.WriteLine("Dpd getting service addons ...");
            var serviceAddonsResult = await _client.Carrier.Dpd.ServiceAddons(serviceType);
            Console.WriteLine($"DpdServiceAddons StatusCode = {serviceAddonsResult.StatusCode}, Count = {serviceAddonsResult?.Result.Count()}");
            


            ////////////////
            /// Branches
            ///////////////
            

            var branchesModel = new BranchSearchModel
            {
                BranchType = 0,
                Country = "CZ",
                Name = "Brno",
                ServiceType = "NP",
                SubCarrierId = null
            };
            

            Console.WriteLine("Dpd getting branches ...");
            var branchesResult = await _client.Carrier.Dpd.Branches(branchesModel);
            Console.WriteLine($"DpdBranches StatusCode = {branchesResult.StatusCode}, Count = {branchesResult?.Result.Total}");
            



            ////////////////
            /// Tracking
            ///////////////
            
            
            var trackingModel = new PackageTrackingStatusRequestModel
            {
                Packages = new List<string> { "23755010135018", "23755010135019" }
            };

            Console.WriteLine("Dpd getting branches ...");
            var trackingResult = await _client.Carrier.Dpd.Tracking(trackingModel);
            Console.WriteLine($"DpdBranches StatusCode = {trackingResult.StatusCode}, Count = {trackingResult?.Result.Count()}");
            
            
        }
    }
}
