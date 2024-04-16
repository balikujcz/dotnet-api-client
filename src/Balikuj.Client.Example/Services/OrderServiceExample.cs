using Balikuj.Client.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class OrderServiceExample
    {
        private readonly BalikujClient _client;

        public OrderServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            ////////////////////////
            /// Order list
            /////////////////////////
            ///

            /*
            Console.WriteLine("Getting orders ...");
            var orders = await _client.OrderList();
            Console.WriteLine($"OrderList StatusCode = {orders.StatusCode}, items = {orders?.Result?.Total}");
            */


            ////////////////////////
            /// Order get
            /////////////////////////
            ///
            /*
            int desiredId = 1;
            
            Console.WriteLine("Getting order ...");
            var order = await _client.OrderGet(desiredId);
            Console.WriteLine($"OrderList StatusCode = {order.StatusCode}, OrderNumber = {order?.Result?.OrderNumber}");
            */

            ////////////////////////
            /// Order update
            /////////////////////////
            ///

            /*
            var updateModel = new OrderUpdateRequest
            {
                Orders = new List<OrderUpdateItem>
                {
                    new OrderUpdateItem() { 
                        Id = 1,
                        CarrierCode = "PPL",
                        CarrierServiceCode = "PPL-Standard",
                        Resolved = true,
                        IsPaid = true,
                        PaidDate = DateTime.Now,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        CustomerNote = "Customer note",
                        InternalNote = "Internal note",
                        PieceCount = 1,
                        TotalWeight = 1
                    }
                },
                GenerateSms = true,
                GenerateEmail = true,
                GenerateDocuments = true,
            };

            Console.WriteLine("Getting order ...");
            var order = await _client.OrderUpdate(updateModel);
            Console.WriteLine($"OrderList StatusCode = {order.StatusCode}, Count = {order?.Result?.Count}");
            */


            ////////////////////////
            /// Order create packages
            /////////////////////////
            ///
            /*
            var packages = new OrderCreatePackageRequest()
            {
                Orders = new List<int> { 1, 20 }
            };

            

            Console.WriteLine("Creating order packages ...");
            var order = await _client.OrderCreatePackages(packages);
            Console.WriteLine($"OrderCreatePackages StatusCode = {order.StatusCode}, OrdersCount = {order?.Result?.Orders.Count}");
            */


        }
    }
}
