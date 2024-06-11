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
            /*
            Console.WriteLine("Creating new application ...");
            var application = await _client.Application.List();
            Console.WriteLine($"ApplicationCreate StatusCode = {application.StatusCode}, items = {application?.Result?.Total}");
            */

            ////////////////////////////
            //// application get
            ////////////////////////////
            /*
            int applicationId = 2;

            Console.WriteLine("Getting the application ...");
            var application = await _client.Application.Get(applicationId);
            Console.WriteLine($"ApplicationGet StatusCode = {application.StatusCode}");
            */


            ////////////////////////////
            /// Application types
            /// /////////////////////////
            /*
            Console.WriteLine("Getting application types ...");
            var application = await _client.Application.Types();
            Console.WriteLine($"ApplicationCreate StatusCode = {application.StatusCode}, result = {application?.Result}");
            */


            ////////////////////////////
            /// Application update            - model
            /// /////////////////////////
            /*
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
            var application = await _client.Application.Update(id, applicationModel);
            Console.WriteLine($"ApplicationUpdate StatusCode = {application.StatusCode}, result = {application?.Result.Status}");
            */



            ////////////////////////////
            /// Application delete
            /// /////////////////////////
            /*
            int applicationId = 1;

            Console.WriteLine("Deleting application ...");
            var application = await _client.Application.Delete(applicationId);
            Console.WriteLine($"ApplicationDelete StatusCode = {application.StatusCode}, result = {application?.Result}");
            */


            ////////////////////////////
            /// Application create
            /// /////////////////////////
            /*
            var model = new ApplicationActivateModel
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
            var application = await _client.Application.Create(model);
            Console.WriteLine($"ApplicationDelete StatusCode = {application.StatusCode}, result = {application?.Result}");
            */



            ////////////////////////////
            /// Application carrier mappings
            /// /////////////////////////
            
             /*
             int applicationId = 2;

             Console.WriteLine("Loading application carrier mappings ...");
             var application = await _client.Application.CarrierMappings(applicationId);
             Console.WriteLine($"ApplicationCarrierMappings StatusCode = {application.StatusCode}, result = {application?.Result}");
            
             */


            ////////////////////////////
            /// Application carrier mapping create
            /// /////////////////////////
            /*
            int applicationId = 2;

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
            var application = await _client.Application.CarrierMappingCreate(applicationId, model);
            Console.WriteLine($"ApplicationCarrierMappingCreate StatusCode = {application.StatusCode}, result = {application?.Result}");
            */
            


            ////////////////////////////
            /// Application carrier mapping get 
            /// /////////////////////////
            /*
            
             int applicationId = 2;
             int mappingId = 3;

             Console.WriteLine("Loading application carrier mapping ...");
             var application = await _client.Application.CarrierMappingGet(mappingId, applicationId);
             Console.WriteLine($"ApplicationCarrierMappingGet StatusCode = {application.StatusCode}, result = {application?.Result}");
            */


            ////////////////////////////
            /// Application carrier mapping update
            /// /////////////////////////
            /*
            
            int applicationId = 2;
            int mappingId = 3;

            var model = new ApplicationCarrierModel
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
             var application = await _client.Application.CarrierMappingUpdate(mappingId, applicationId, model);
             Console.WriteLine($"ApplicationCarrierMappingUpdate StatusCode = {application.StatusCode}, result = {application?.Result}");            
            */



            ////////////////////////////
            /// Application carrier mapping delete
            /// /////////////////////////

            /*
            int applicationId = 2;
            int mappingId = 6;

             Console.WriteLine("Loading application carrier mapping ...");
             var application = await _client.Application.CarrierMappingDelete(mappingId, applicationId);
             Console.WriteLine($"ApplicationCarrierMappingDelete StatusCode = {application.StatusCode}, result = {application?.Result}");
            
            */



        }
    }
}
