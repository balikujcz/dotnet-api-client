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

using Balikuj.Client.Models.Printer;

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

            
            Console.WriteLine("Getting printers ...");
            var printerList = await _client.Printer.List();
            Console.WriteLine($"PrinterList StatusCode = {printerList.StatusCode}, count = {printerList?.Result?.Total}");
            


            ////////////////////
            /// Printer detail
            ////////////////////

            
            int desiredId = 1;

            Console.WriteLine("Getting printer detail ...");
            var printerDetail = await _client.Printer.Detail(desiredId);
            Console.WriteLine($"PrinterDetail StatusCode = {printerDetail.StatusCode}, Name = {printerDetail?.Result?.Name}");
            


            ////////////////////
            /// Printer update
            ////////////////////

            
            // int desiredId = 1;

            var updateModel = new PrinterUpdateRequest()
            {
                Name = "New Printer Name - Updated",
            };

            Console.WriteLine("Getting printer detail ...");
            var printerUpdate = await _client.Printer.Update(desiredId, updateModel);
            Console.WriteLine($"PrinterDetail StatusCode = {printerUpdate.StatusCode}, Name = {printerUpdate?.Result?.Name}");
            

            
            ////////////////////////
            /// Printer token list
            ////////////////////////
            
            Console.WriteLine("Getting printer tokens ...");
            var tokenList = await _client.Printer.TokenList();
            Console.WriteLine($"PrinterTokenList StatusCode = {tokenList.StatusCode}, Count = {tokenList?.Result?.Count}");
            


            ////////////////////////
            /// Printer token create
            ////////////////////////

            
            var token = new PrinterTokenCreateRequest()
            {
                Description = "Test printer token x",
            };
            
            Console.WriteLine("Creating printer token ...");
            var createdToken = await _client.Printer.CreatePrinterToken(token);
            Console.WriteLine($"CreatePrinterToken StatusCode = {createdToken.StatusCode}, CreatedOn = {createdToken?.Result?.Created.ToString()}");
            


            ////////////////////////
            /// Printer token update
            ////////////////////////

            
            // int desiredId = 1;
            
            var tokenUpdate = new PrinterTokenUpdateRequest()
            {
                Description = "Test printer token updated",
            };
            
            Console.WriteLine("Udpating printer token ...");
            var updatedToken = await _client.Printer.UpdatePrinterToken(desiredId, tokenUpdate);
            Console.WriteLine($"UpdatePrinterToken StatusCode = {updatedToken.StatusCode}, UpdatedOn = {updatedToken?.Result?.Updated.ToString()}");
            


            ////////////////////////
            /// Printer token delete
            ////////////////////////

            
            // int desiredId = 3;
            
            Console.WriteLine("Deleting printer token ...");
            var deletedToken = await _client.Printer.DeletePrinterToken(desiredId);
            Console.WriteLine($"DeletePrinterToken StatusCode = {deletedToken.StatusCode}, Success = {deletedToken?.Result}");
            

        }
    }
}
