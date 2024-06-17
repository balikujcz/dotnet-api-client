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

using Balikuj.Client.Models.Picking;

namespace Balikuj.Client.Example.Services
{
    public class PickingServiceExample
    {
        private readonly BalikujClient _client;

        public PickingServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            ////////////////////
            /// Picking start
            ////////////////////

            
            int orderId = 2;

            Console.WriteLine("Starting picking order  ...");
            var pickingStart = await _client.Picking.Start(orderId);
            Console.WriteLine($"PickingStart StatusCode = {pickingStart.StatusCode}, Success = {pickingStart?.Result}");
            
            

            ////////////////////
            /// Picking cancel
            ////////////////////

            // int orderId = 2;

            Console.WriteLine("Cancelling picking order  ...");
            var pickingCancel = await _client.Picking.Cancel(orderId);
            Console.WriteLine($"PickingCancel StatusCode = {pickingCancel.StatusCode}, Success = {pickingCancel?.Result}");
            



            ////////////////////
            /// Picking save
            ////////////////////

            // int orderId = 2;
            var saveModel = new PickingSave()
            {
                Items = new List<PickingSaveItem>()
                {
                    new PickingSaveItem()
                    {
                        OrderItemId = 1,
                        PickedQuantity = 1
                    }
                }
            };

            Console.WriteLine("Saving picking order  ...");
            var pickingSave = await _client.Picking.Save(orderId, saveModel);
            Console.WriteLine($"PickingSave StatusCode = {pickingSave.StatusCode}, Success = {pickingSave?.Result}");


            ////////////////////
            /// Picking finish
            ////////////////////
            
            // int orderId = 2;

            Console.WriteLine("Finishing picking order  ...");
            var pickingFinish = await _client.Picking.Finish(orderId);
            Console.WriteLine($"PickingFinish StatusCode = {pickingFinish.StatusCode}, Success = {pickingFinish?.Result}");
            
        }
    }
}
