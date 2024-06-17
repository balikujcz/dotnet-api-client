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

using System;

namespace Balikuj.Client.Models.Order
{
    public class OrderUpdateItem
    {
        /// <summary>
        /// List of order IDs for which we want to change the status
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Carrier code under which the order should be sent. It is possible to change only both CarrierCode + CarrierServiceCode together. Not every e-commerce platform allows changing the carrier if the order is already created (e.g., Upgates cannot do that). Therefore, changing the carrier here may not be reflected in the order settings in the carrier's system.
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Carrier service code under which the order should be sent. It is possible to change only both CarrierCode + CarrierServiceCode together.
        /// </summary>
        public string CarrierServiceCode { get; set; }

        /// <summary>
        /// Allows marking the order as resolved/unresolved
        /// </summary>
        public bool? Resolved { get; set; }

        /// <summary>
        /// Is the order paid?
        /// </summary>
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Date of order payment. If not filled in and the order is set as paid, the current date will be used.
        /// </summary>
        public DateTime? PaidDate { get; set; }

        /// <summary>
        /// Order status ID
        /// </summary>
        public int? StatusId { get; set; }

        /// <summary>
        /// ID of the order's payment method
        /// </summary>
        public int? PaymentMethodId { get; set; }

        /// <summary>
        /// Customer note for the order
        /// </summary>
        public string CustomerNote { get; set; }

        /// <summary>
        /// Internal note for the order
        /// </summary>
        public string InternalNote { get; set; }

        /// <summary>
        /// Number of shipments with the given carrier
        /// </summary>
        public int? PieceCount { get; set; }

        /// <summary>
        /// Total weight of the order / shipments
        /// </summary>
        public decimal? TotalWeight { get; set; }

    }
}
