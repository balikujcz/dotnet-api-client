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

using Balikuj.Client.Errors;
using System.Collections.Generic;

namespace Balikuj.Client.Models.Package
{
    public class PackageCreateModel
    {
        /// <summary>
        /// ID of the record in the system
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// Carrier package number
        /// </summary>
        public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Custom package number (order number, etc.)
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Package index within the shipment. If the shipment contains multiple unique packages, it specifies the package index within the shipment
        /// </summary>
        public int? PieceIndex { get; set; }

        /// <summary>
        /// ID of the order to which the package belongs. If the package does not belong to an order, it returns null
        /// </summary>
        public int? OrderId { get; set; }

        public int? OrderNumber { get; set; }

        /// <summary>
        /// Link to download the label for the package
        /// </summary>
        public string LabelUrl { get; set; }

        /// <summary>
        /// Link to track the package
        /// </summary>
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Status code of the package
        /// </summary>
        public int StatusCode { get; set; } = 200;

        /// <summary>
        /// Status message of the package
        /// </summary>
        public string Message { get; set; } = "OK";

        /// <summary>
        /// List of potential error messages from the carrier API. Divided by entity, status code, and error message text
        /// </summary>
        public IList<ApiCarrierError> CarrierErrors { get; set; }
    }
}
