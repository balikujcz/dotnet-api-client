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

using Balikuj.Client.Models.Order;

namespace Balikuj.Client.Example.Services
{
    public class OrderServiceExample
    {
        private readonly BalikujClient _client;

        public OrderServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {
            ////////////////////////
            /// Order list
            /////////////////////////

            
            Console.WriteLine("Getting orders ...");
            var orderList = await _client.Order.List();
            Console.WriteLine($"OrderList StatusCode = {orderList.StatusCode}, items = {orderList?.Result?.Total}");
            


            ////////////////////////
            /// Order get
            /////////////////////////
            
            int desiredId = 1;
            
            Console.WriteLine("Getting order ...");
            var orderGet = await _client.Order.Get(desiredId);
            Console.WriteLine($"OrderList StatusCode = {orderGet.StatusCode}, OrderNumber = {orderGet?.Result?.OrderNumber}");
            

            ////////////////////////
            /// Order update
            /////////////////////////

            
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
            var orderUpdate = await _client.Order.Update(updateModel);
            Console.WriteLine($"OrderList StatusCode = {orderUpdate.StatusCode}, Count = {orderUpdate?.Result?.Count}");
            


            ////////////////////////
            /// Order create packages
            /////////////////////////
            
            var packages = new OrderCreatePackageRequest()
            {
                Orders = new List<int> { 1, 20 }
            };


            Console.WriteLine("Creating order packages ...");
            var orderCreatePackages = await _client.Order.CreatePackages(packages);
            Console.WriteLine($"OrderCreatePackages StatusCode = {orderCreatePackages.StatusCode}, OrdersCount = {orderCreatePackages?.Result?.Orders.Count}");
            


            ////////////////////////
            /// Order item update
            /////////////////////////
            

            // int desiredId = 1;

            var items = new OrderItemUpdateRequest()
            {
                Items = new List<int>() { 43, 52},
                Resolved = true,
            };


            Console.WriteLine("Updating order items ...");
            var orderItemUpdate = await _client.Order.ItemUpdate(desiredId, items);
            Console.WriteLine($"OrderItemUpdate StatusCode = {orderItemUpdate.StatusCode}, Count = {orderItemUpdate?.Result?.Count()}");
            


            ////////////////////////
            /// Order status get
            /////////////////////////

            
            Console.WriteLine("Getting all order statuses ...");
            var orderStatusGet = await _client.Order.Status();
            Console.WriteLine($"OrderStatus StatusCode = {orderStatusGet.StatusCode}, Count = {orderStatusGet?.Result?.Count()}");
            


            ////////////////////////
            /// Order status get by id
            /////////////////////////
            
            // int desiredId = 1;
            
            Console.WriteLine("Getting order status by id ...");
            var orderStatusById = await _client.Order.StatusGet(desiredId);
            Console.WriteLine($"OrderStatusGet StatusCode = {orderStatusById.StatusCode}, Id = {orderStatusById?.Result?.Id}");
            


            ////////////////////////
            /// Order status update
            /////////////////////////

            
            // int desiredId = 1;

            var statusUpdateModel = new OrderStatusUpdateRequest
            {
                SourceId = new string[] { "1" },
                Name = "Test",
                TextColor = "#000000",
                BackgroundColor = "#FFFFFF",
                IsSystem = false,
                DisplayOrder = 1
            };
            
            Console.WriteLine("Updating order status ...");
            var order = await _client.Order.StatusUpdate(desiredId, statusUpdateModel);
            Console.WriteLine($"OrderStatusUpdate StatusCode = {order.StatusCode}, Id = {order?.Result?.Id}");
            


            ////////////////////////
            /// Order status create
            /////////////////////////

            
            var createModel = new OrderStatusCreateRequest
            {
                Name = "Test",
                TextColor = "#000000",
                BackgroundColor = "#FFFFFF",
                SourceId = new string[] { "1" },
                DisplayOrder = 1000
            };
            
            Console.WriteLine("Creating order status ...");
            var orderStatusCreate = await _client.Order.StatusCreate(createModel);
            Console.WriteLine($"OrderStatusCreate StatusCode = {orderStatusCreate.StatusCode}, Id = {orderStatusCreate?.Result?.Id}");
            


            ////////////////////////
            /// Order status delete
            /////////////////////////

            
            // int desiredId = 1;
            
            Console.WriteLine("Deleting order status ...");
            var orderStatusId = await _client.Order.StatusDelete(desiredId);
            Console.WriteLine($"OrderStatusDelete StatusCode = {orderStatusId.StatusCode}, Success = {orderStatusId?.Result}");
            


            ////////////////////////
            /// Order payment method
            /////////////////////////
            

            
            Console.WriteLine("Getting payment methods ...");
            var orderPaymentList = await _client.Order.PaymentMethodList();
            Console.WriteLine($"OrderPaymentMethod StatusCode = {orderPaymentList.StatusCode}, Count = {orderPaymentList?.Result?.Count()}");
            
            

            ////////////////////////////
            /// Order payment method get
            ////////////////////////////
            

            
            // int desiredId = 1;
            
            Console.WriteLine("Getting the payment method ...");
            var orderPaymentMethods = await _client.Order.PaymentMethodGet(desiredId);
            Console.WriteLine($"OrderPaymentMethod StatusCode = {orderPaymentMethods.StatusCode}, Id = {orderPaymentMethods?.Result?.Id}");
            


            ///////////////////////////////
            /// Order payment method update
            ///////////////////////////////
            

            
            // int desiredId = 2;

            var methodUpdateModel = new OrderPaymentUpdateRequest
            {
                Name = "Test",
                DisplayOrder = 1000,
                IsSystem = false,
                SourceId = new string[] { "1" },
                ImageUrl = "https://www.google.com",
                
            };
            
            Console.WriteLine("Updating the payment method ...");
            var orderPaymentMethodUpdate = await _client.Order.PaymentMethodUpdate(desiredId, methodUpdateModel);
            Console.WriteLine($"OrderPaymentMethodUpdate StatusCode = {orderPaymentMethodUpdate.StatusCode}, Id = {orderPaymentMethodUpdate?.Result?.Id}");
            



            ///////////////////////////////
            /// Order payment method create
            ///////////////////////////////
            
            
            var createPaymentModel = new OrderPaymentCreateRequest
            {
                Name = "Test",
                DisplayOrder = 1000,
                IsSystem = false,
                SourceId = new string[] { "1" },
                ImageUrl = "https://www.google.com",
                
            };
            
            Console.WriteLine("Creating the payment method ...");
            var orderPaymentMethodCreate = await _client.Order.PaymentMethodCreate(createPaymentModel);
            Console.WriteLine($"OrderPaymentMethodCreate StatusCode = {orderPaymentMethodCreate.StatusCode}, Id = {orderPaymentMethodCreate?.Result?.Id}");
            

            ////////////////////////////
            /// Order payment method delete
            ////////////////////////////
            

            
            // int desiredId = 8;
            
            Console.WriteLine("Deleting the payment method ...");
            var orderPaymentDelete = await _client.Order.PaymentMethodDelete(desiredId);
            Console.WriteLine($"OrderPaymentMethodDelete StatusCode = {orderPaymentDelete.StatusCode}, Success = {orderPaymentDelete?.Result}");
            



        }
    }
}
