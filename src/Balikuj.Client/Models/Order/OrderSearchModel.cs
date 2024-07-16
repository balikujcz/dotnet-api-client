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

using Balikuj.Client.Models.Base;
using System.Collections.Generic;

namespace Balikuj.Client.Models.Order
{
    public class OrderSearchModel : BaseSearchModel
    {
        /// <summary>
        /// Additional parameters for further searching
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// Order ID to search for
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Shipment creation date from in YYYY-MM-DD format
        /// </summary>
        public string CreatedFrom { get; set; }

        /// <summary>
        /// Shipment creation date to in YYYY-MM-DD format
        /// </summary>
        public string CreatedTo { get; set; }

        /// <summary>
        /// Carrier codes for which we are searching for orders
        /// </summary>
        public List<string> CarrierCodes { get; set; }

        /// <summary>
        /// Column name for sorting
        /// </summary>
        public string SortField { get; set; }

        /// <summary>
        /// Display order
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// Application IDs for which we want to search for orders
        /// </summary>
        /// <example>10,12,30</example>
        public List<int> Application { get; set; }

        /// <summary>
        /// Status IDs for filtering by status
        /// </summary>
        public List<int> Status { get; set; }
    }
}

