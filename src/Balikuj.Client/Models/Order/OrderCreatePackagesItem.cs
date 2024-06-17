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

using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Order
{
    public class OrderCreatePackagesItem
    {
        [JsonIgnore]
        public int OrderId { get; set; }

        /// <summary>
        /// ID of the shipment for work in the balíkuj system
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Number of the order
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Number of the shipment carrier
        /// </summary>
        public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Name of the recipient of the order
        /// </summary>
        public string OrderDeliveryName { get; set; }

        /// <summary>
        /// Name of the company of the recipient of the order
        /// </summary>
        public string OrderDeliveryCompany { get; set; }

        /// <summary>
        /// Informations whether the creation was successful or not
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Text of any error message
        /// </summary>
        public string Message { get; set; }
    }
}
