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
            var orders = await _client.Order.List();
            Console.WriteLine($"OrderList StatusCode = {orders.StatusCode}, items = {orders?.Result?.Total}");
            */


            ////////////////////////
            /// Order get
            /////////////////////////
            ///
            /*
            int desiredId = 1;
            
            Console.WriteLine("Getting order ...");
            var order = await _client.Order.Get(desiredId);
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
            var order = await _client.Order.Update(updateModel);
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
            var order = await _client.Order.CreatePackages(packages);
            Console.WriteLine($"OrderCreatePackages StatusCode = {order.StatusCode}, OrdersCount = {order?.Result?.Orders.Count}");
            */


            ////////////////////////
            /// Order item update
            /////////////////////////
            ///

            /*
            int desiredId = 1;

            var items = new OrderItemUpdateRequest()
            {
                // create new list of ints
                Items = new List<int>() { 43, 52},
                Resolved = true,
            };


            Console.WriteLine("Updating order items ...");
            var order = await _client.Order.ItemUpdate(desiredId, items);
            Console.WriteLine($"OrderItemUpdate StatusCode = {order.StatusCode}, Count = {order?.Result?.Count()}");
            */


            ////////////////////////
            /// Order status get
            /////////////////////////
            ///

            /*
            Console.WriteLine("Getting all order statuses ...");
            var order = await _client.Order.Status();
            Console.WriteLine($"OrderStatus StatusCode = {order.StatusCode}, Count = {order?.Result?.Count()}");
            */


            ////////////////////////
            /// Order status get by id
            /////////////////////////
            ///

            /*
            int desiredId = 1;
            
            Console.WriteLine("Getting order status by id ...");
            var order = await _client.Order.StatusGet(desiredId);
            Console.WriteLine($"OrderStatusGet StatusCode = {order.StatusCode}, Id = {order?.Result?.Id}");
            */


            ////////////////////////
            /// Order status update
            /////////////////////////
            ///

            /*
            int desiredId = 1;

            var updateModel = new OrderStatusUpdateRequest
            {
                SourceId = new string[] { "1" },
                Name = "Test",
                TextColor = "#000000",
                BackgroundColor = "#FFFFFF",
                IsSystem = false,
                DisplayOrder = 1
            };
            
            Console.WriteLine("Updating order status ...");
            var order = await _client.Order.StatusUpdate(desiredId, updateModel);
            Console.WriteLine($"OrderStatusUpdate StatusCode = {order.StatusCode}, Id = {order?.Result?.Id}");
            */


            ////////////////////////
            /// Order status create
            /////////////////////////
            ///

            /*
            var createModel = new OrderStatusCreateRequest
            {
                Name = "Test",
                TextColor = "#000000",
                BackgroundColor = "#FFFFFF",
                SourceId = new string[] { "1" },
                DisplayOrder = 1000
            };
            
            Console.WriteLine("Creating order status ...");
            var order = await _client.Order.StatusCreate(createModel);
            Console.WriteLine($"OrderStatusCreate StatusCode = {order.StatusCode}, Id = {order?.Result?.Id}");
            */


            ////////////////////////
            /// Order status delete
            /////////////////////////
            ///

            /*
            int desiredId = 1;
            
            Console.WriteLine("Deleting order status ...");
            var order = await _client.Order.StatusDelete(desiredId);
            Console.WriteLine($"OrderStatusDelete StatusCode = {order.StatusCode}, Success = {order?.Result}");
            */


            ////////////////////////
            /// Order payment method
            /////////////////////////
            ///

            /*
            Console.WriteLine("Getting payment methods ...");
            var order = await _client.Order.PaymentMethodList();
            Console.WriteLine($"OrderPaymentMethod StatusCode = {order.StatusCode}, Count = {order?.Result?.Count()}");
            */
            

            ////////////////////////////
            /// Order payment method get
            ////////////////////////////
            ///

            /*
            int desiredId = 1;
            
            Console.WriteLine("Getting the payment method ...");
            var orderPaymentMethods = await _client.Order.PaymentMethodGet(desiredId);
            Console.WriteLine($"OrderPaymentMethod StatusCode = {orderPaymentMethods.StatusCode}, Id = {orderPaymentMethods?.Result?.Id}");
            */


            ///////////////////////////////
            /// Order payment method update
            ///////////////////////////////
            ///

            /*
            int desiredId = 2;

            var updateModel = new OrderPaymentUpdateRequest
            {
                Name = "Test",
                DisplayOrder = 1000,
                IsSystem = false,
                SourceId = new string[] { "1" },
                ImageUrl = "https://www.google.com",
                
            };
            
            Console.WriteLine("Updating the payment method ...");
            var orderPaymentMethods = await _client.Order.PaymentMethodUpdate(desiredId, updateModel);
            Console.WriteLine($"OrderPaymentMethodUpdate StatusCode = {orderPaymentMethods.StatusCode}, Id = {orderPaymentMethods?.Result?.Id}");
            */



            ///////////////////////////////
            /// Order payment method create
            ///////////////////////////////
            ///
            /* RETURN ID?
            var updateModel = new OrderPaymentCreateRequest
            {
                Name = "Test",
                DisplayOrder = 1000,
                IsSystem = false,
                SourceId = new string[] { "1" },
                ImageUrl = "https://www.google.com",
                
            };
            
            Console.WriteLine("Creating the payment method ...");
            var orderPaymentMethods = await _client.Order.PaymentMethodCreate(updateModel);
            Console.WriteLine($"OrderPaymentMethodCreate StatusCode = {orderPaymentMethods.StatusCode}, Id = {orderPaymentMethods?.Result?.Id}");
            */

            ////////////////////////////
            /// Order payment method delete
            ////////////////////////////
            ///

            /*
            int desiredId = 8;
            
            Console.WriteLine("Deleting the payment method ...");
            var orderPaymentMethods = await _client.Order.PaymentMethodDelete(desiredId);
            Console.WriteLine($"OrderPaymentMethodDelete StatusCode = {orderPaymentMethods.StatusCode}, Success = {orderPaymentMethods?.Result}");
            */



        }
    }
}
