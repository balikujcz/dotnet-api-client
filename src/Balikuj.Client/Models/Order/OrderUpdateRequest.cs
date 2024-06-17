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

using System.Collections.Generic;

namespace Balikuj.Client.Models.Order
{
    public class OrderUpdateRequest
    {
        /// <summary>
        /// List of orders we want to update. The maximum number of orders for update is 100.
		/// </summary>
		public List<OrderUpdateItem> Orders { get; set; }

        /// <summary>
        /// If filled in, it determines whether the corresponding documents will be generated when the status changes for the given e-shop platform. Not all e-shop applications/platforms support this function
        /// </summary>
        public bool? GenerateDocuments { get; set; }

        /// <summary>
        /// If filled in, it determines whether SMS messages will be generated when the order status changes. Setting according to the selected e-shop application/platform supporting this function
        /// </summary>
        public bool? GenerateSms { get; set; }

        /// <summary>
        /// If filled in, it determines whether email messages will be generated when the order status changes. Setting according to the selected e-shop application/platform supporting this function
        /// </summary>
        public bool? GenerateEmail { get; set; }
    }
}
