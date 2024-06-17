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

using Balikuj.Client.Models.Label;

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
            
            var enumType = LabelType.Pdf;

            Console.WriteLine("Getting not printed labels accounts ...");
            var notPrinted = await _client.Label.NotPrinted(enumType);
            Console.WriteLine($"LabelNotPrinted StatusCode = {notPrinted.StatusCode}, Count = {notPrinted?.Result?.Count}");
            

            /////////////////////////
            /// Label print
            /// /////////////////////
            
            var printModel = new LabelPackageModel
            {
                OnePerPage = true,
                Skip = 0,
                Packages = new List<int> { 5, 6}

            };

            string type = "pdf";

            Console.WriteLine("Printing labels ...");
            var printed = await _client.Label.Print(printModel, type);
            Console.WriteLine($"LabelPrint StatusCode = {printed.StatusCode}, Count = {printed?.Result.Count()}");
            


            /////////////////////////
            /// Label print orders
            /////////////////////////
            
            
            var printOrderModel = new LabelOrderModel
            {
                OnePerPage = true,
                Skip = 0,
                Orders = new List<int> { 30 }

            };

            // string type = "pdf";

            Console.WriteLine("Printing order labels ...");
            var printOrder = await _client.Label.PrintOrders(printOrderModel, type);
            Console.WriteLine($"LabelPrintOrders StatusCode = {printOrder.StatusCode}, Count = {printOrder?.Result.Count()}");
            
        }
    }
}
