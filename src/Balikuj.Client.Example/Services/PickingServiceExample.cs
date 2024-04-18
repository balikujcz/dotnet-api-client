using Balikuj.Client.Models.Picking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            /*
            int orderId = 2;

            Console.WriteLine("Starting picking order  ...");
            var orders = await _client.PickingStart(orderId);
            Console.WriteLine($"PickingStart StatusCode = {orders.StatusCode}, Success = {orders?.Result}");
            */


            ////////////////////
            /// Picking cancel
            ////////////////////

            /*
            int orderId = 2;

            Console.WriteLine("Cancelling picking order  ...");
            var orders = await _client.PickingCancel(orderId);
            Console.WriteLine($"PickingCancel StatusCode = {orders.StatusCode}, Success = {orders?.Result}");
            */



            ////////////////////
            /// Picking save
            ////////////////////

            /*
            int orderId = 2;
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
            var orders = await _client.PickingSave(orderId, saveModel);
            Console.WriteLine($"PickingSave StatusCode = {orders.StatusCode}, Success = {orders?.Result}");
            */


            ////////////////////
            /// Picking finish
            ////////////////////

            /*
            int orderId = 2;

            Console.WriteLine("Finishing picking order  ...");
            var orders = await _client.PickingFinish(orderId);
            Console.WriteLine($"PickingFinish StatusCode = {orders.StatusCode}, Success = {orders?.Result}");
            */
        }
    }
}
