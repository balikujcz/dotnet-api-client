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
            
            Console.WriteLine("Creating new application ...");
            var list = await _client.Application.List();
            Console.WriteLine($"ApplicationCreate StatusCode = {list.StatusCode}, items = {list?.Result?.Total}");
            

            ////////////////////////////
            //// application get
            ////////////////////////////
            
            int applicationId = 2;

            Console.WriteLine("Getting the application ...");
            var applicationGet = await _client.Application.Get(applicationId);
            Console.WriteLine($"ApplicationGet StatusCode = {applicationGet.StatusCode}");
            


            ////////////////////////////
            /// Application types
            /// /////////////////////////
            
            Console.WriteLine("Getting application types ...");
            var applicationTypes = await _client.Application.Types();
            Console.WriteLine($"ApplicationCreate StatusCode = {applicationTypes.StatusCode}, result = {applicationTypes?.Result}");
            


            ////////////////////////////
            /// Application update      
            /// /////////////////////////
            
            int id = 2;
            var applicationModel = new ApplicationModel
            {
                Type = new ApplicationTypeModel
                {
                    Id = 3,
                    Code = "UPGATES",
                    Name = "Napojení na upgates UPDATE TEST",
                    Description = "Test description",
                },
                Domain = "programatori",
                Note = "Test note",
                Activated = DateTime.Now,
                Status = ApplicationStatus.Active,
                AdditionalProperties = new Dictionary<string, object>
                {
                    { "contactCompany", "test" },
                    { "contactName", "test" },
                    { "contactStreet", "test" },
                    { "contactCity", "test" },
                    { "contactZip", "test" },
                    { "contactPhone", "test" },
                    { "contactEmail", "test" },
                    { "contactTaxNumber", "test" },
                    { "contactVatNumber", "test" },
                    { "contactTaxId", "test" },
                    { "contactBankAccount", "test" },
                    { "contactBankCode", "test" },
                    { "contactBankSpecificSymbol", "test" },
                    { "contactBankIban", "test" },
                    { "contactBankSwift", "test" },
                }
            };

            Console.WriteLine("Updating application types ...");
            var applicationUpdate = await _client.Application.Update(id, applicationModel);
            Console.WriteLine($"ApplicationUpdate StatusCode = {applicationUpdate.StatusCode}, result = {applicationUpdate?.Result.Status}");
            



            ////////////////////////////
            /// Application delete
            /// /////////////////////////
            /*
            int applicationId = 1;
            */

            Console.WriteLine("Deleting application ...");
            var applicationDelete = await _client.Application.Delete(applicationId);
            Console.WriteLine($"ApplicationDelete StatusCode = {applicationDelete.StatusCode}, result = {applicationDelete?.Result}");
            


            ////////////////////////////
            /// Application create
            /// /////////////////////////
            
            var createModel = new ApplicationActivateModel
            {
                Code = "UPGATES",
                AdditionalProperties = new Dictionary<string, JsonElement>
                {
                   { "apiLogin", JsonDocument.Parse("\"07460775\"").RootElement },
                   { "apiKey", JsonDocument.Parse("\"%M#UL2QFDCCbYv+thdbD\"").RootElement },
                   { "eshopName", JsonDocument.Parse("\"programatori\"").RootElement },
                   { "serverName", JsonDocument.Parse("\"t1\"").RootElement },
                   { "domain", JsonDocument.Parse("\"programatori.cz\"").RootElement }
                }
            };

            Console.WriteLine("Creating application ...");
            var applicationCreate = await _client.Application.Create(createModel);
            Console.WriteLine($"ApplicationDelete StatusCode = {applicationCreate.StatusCode}, result = {applicationCreate?.Result}");
            



            ////////////////////////////
            /// Application carrier mappings
            /// /////////////////////////
             
             // int applicationId = 2;
             
             Console.WriteLine("Loading application carrier mappings ...");
             var applicationCarrierMapping = await _client.Application.CarrierMappings(applicationId);
             Console.WriteLine($"ApplicationCarrierMappings StatusCode = {applicationCarrierMapping.StatusCode}, result = {applicationCarrierMapping?.Result}");
            
             


            //////////////////////////////////////
            /// Application carrier mapping create
            /// //////////////////////////////////
            
            // int applicationId = 2;

            var model = new ApplicationCarrierModel
            {
                ApplicationId = 3,
                CarrierCode = "DPD",
                CarrierName = "DPD",
                ServiceCode = "Private",
                Id = 0,
                Name = "DPD Private",
                ServiceName = "Private",
                SourceId = ["B", "A"],
            };

            Console.WriteLine("Creating application carrier mapping ...");
            var applicationMappingCreate = await _client.Application.CarrierMappingCreate(applicationId, model);
            Console.WriteLine($"ApplicationCarrierMappingCreate StatusCode = {applicationMappingCreate.StatusCode}, result = {applicationMappingCreate?.Result}");
            
            


            ////////////////////////////
            /// Application carrier mapping get 
            /// /////////////////////////
            
            
             // int applicationId = 2;
             int mappingId = 3;

             Console.WriteLine("Loading application carrier mapping ...");
             var applicationMappingGet = await _client.Application.CarrierMappingGet(mappingId, applicationId);
             Console.WriteLine($"ApplicationCarrierMappingGet StatusCode = {applicationMappingGet.StatusCode}, result = {applicationMappingGet?.Result}");
            


            ////////////////////////////
            /// Application carrier mapping update
            /// /////////////////////////
            
            
            // int applicationId = 2;
            // int mappingId = 3;

            var updateModel = new ApplicationCarrierModel
            {
                Id = 3,
                ApplicationId = 2,
                CarrierCode = "DPD",
                CarrierName = "DPD",
                ServiceCode = "Private",
                Name = "DPD Private update",
                ServiceName = "Private",
                SourceId = ["B", "A"]
            };

             Console.WriteLine("Loading application carrier mapping ...");
             var applicationCarrierUpdate = await _client.Application.CarrierMappingUpdate(mappingId, applicationId, updateModel);
             Console.WriteLine($"ApplicationCarrierMappingUpdate StatusCode = {applicationCarrierUpdate.StatusCode}, result = {applicationCarrierUpdate?.Result}");            
            



            ////////////////////////////
            /// Application carrier mapping delete
            /// /////////////////////////

            
            // int applicationId = 2;
            // int mappingId = 6;

             Console.WriteLine("Loading application carrier mapping ...");
             var applicationCarrierDelete = await _client.Application.CarrierMappingDelete(mappingId, applicationId);
             Console.WriteLine($"ApplicationCarrierMappingDelete StatusCode = {applicationCarrierDelete.StatusCode}, result = {applicationCarrierDelete?.Result}");
            
            



        }
    }
}
