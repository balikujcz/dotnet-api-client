using Balikuj.Client.Models.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class PrinterServiceExample
    {
        private readonly BalikujClient _client;

        public PrinterServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {

            ////////////////////
            /// Printer List
            ////////////////////

            /*
            Console.WriteLine("Getting printers ...");
            var printers = await _client.PrinterList();
            Console.WriteLine($"PrinterList StatusCode = {printers.StatusCode}, count = {printers?.Result?.Total}");
            */


            ////////////////////
            /// Printer detail
            ////////////////////

            /*
            int desiredId = 1;

            Console.WriteLine("Getting printer detail ...");
            var printer = await _client.PrinterDetail(desiredId);
            Console.WriteLine($"PrinterDetail StatusCode = {printer.StatusCode}, Name = {printer?.Result?.Name}");
            */


            ////////////////////
            /// Printer update
            ////////////////////

            /*
            int desiredId = 1;

            var updateModel = new PrinterUpdateRequest()
            {
                Name = "New Printer Name - Updated",
            };

            Console.WriteLine("Getting printer detail ...");
            var printer = await _client.PrinterUpdate(desiredId, updateModel);
            Console.WriteLine($"PrinterDetail StatusCode = {printer.StatusCode}, Name = {printer?.Result?.Name}");
            */


            ////////////////////////
            /// Printer token list
            ////////////////////////
            
            Console.WriteLine("Getting printer tokens ...");
            var tokenList = await _client.PrinterTokenList();
            Console.WriteLine($"PrinterTokenList StatusCode = {tokenList.StatusCode}, Count = {tokenList?.Result?.Count}");



            ////////////////////////
            /// Printer token create
            ////////////////////////

            /*
            var token = new PrinterTokenCreateRequest()
            {
                Description = "Test printer token x",
            };
            
            Console.WriteLine("Creating printer token ...");
            var createdToken = await _client.CreatePrinterToken(token);
            Console.WriteLine($"CreatePrinterToken StatusCode = {createdToken.StatusCode}, CreatedOn = {createdToken?.Result?.Created.ToString()}");
            */


            ////////////////////////
            /// Printer token update
            ////////////////////////

            /*
            int desiredId = 1;
            
            var token = new PrinterTokenUpdateRequest()
            {
                Description = "Test printer token updated",
            };
            
            Console.WriteLine("Udpating printer token ...");
            var updatedToken = await _client.UpdatePrinterToken(desiredId, token);
            Console.WriteLine($"UpdatePrinterToken StatusCode = {updatedToken.StatusCode}, UpdatedOn = {updatedToken?.Result?.Updated.ToString()}");
            */


            ////////////////////////
            /// Printer token delete
            ////////////////////////

            /*
            int desiredId = 3;
            
            Console.WriteLine("Deleting printer token ...");
            var deletedToken = await _client.DeletePrinterToken(desiredId);
            Console.WriteLine($"DeletePrinterToken StatusCode = {deletedToken.StatusCode}, Success = {deletedToken?.Result}");
            */


            ////////////////////////
            /// Printer print label
            ////////////////////////
            
            // TODO : Implement this

            /*
            var printLabel = new PrinterPrint()
            {
                Hash = "hash",
                PrinterName = "MyPrinter12",
            };
            
            Console.WriteLine("Printing label ...");
            var printedLabel = await _client.PrintLabel(printLabel);
            Console.WriteLine($"PrintLabel StatusCode = {printedLabel.StatusCode}, Success = {printedLabel?.Result}");
            */


        }
    }
}
