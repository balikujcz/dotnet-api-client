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

using Balikuj.Client.Models.Addresses;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Order
{
    public class OrderModel
    {
        /// <summary>
        /// Watch out, must be System.Text.Json, because Newtonsoft didn't work and put items into an array
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// Admin Url?
        /// </summary>
        public string AdminUrl { get; set; }

        /// <summary>
        /// Application in which the order was created
        /// </summary>
        public OrderApplication Application { get; set; }

        /// <summary>
        /// Facturation address
        /// </summary>
        public AddressModel BillingAddress { get; set; }

        /// <summary>
        /// Date of order deletion
        /// </summary>
        public DateTime? Canceled { get; set; }

        /// <summary>
        /// Information about the carrier and service
        /// </summary>
        public OrderCarrier Carrier { get; set; }

        /// <summary>
        /// Date of creation
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Currency of the order, three-letter ISO 4217 code https://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        public string Currency { get; set; }

        // Doesnt show, serves as a helper variable to eliminate duplicate access to the DB/cache processing of orders into PDF
        [JsonIgnore]
        public string CurrencyLocale { get; set; }

        /// <summary>
        /// Customer note
        /// </summary>
        public string CustomerNote { get; set; }

        /// <summary>
        /// Address for delivery, if different from billing, can be null
        /// </summary>
        public AddressModel DeliveryAddress { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// External order number
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// Internal note for the order
        /// </summary>
        public string InternalNote { get; set; }

        /// <summary>
        /// Is order paid?
        /// </summary>
        public bool IsPaid { get; set; }

        /// <summary>
        /// Items of the order
        /// </summary>
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// JSON data
        /// </summary>
        public string JsonData { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        public string Language { get; set; }


        // 2024-03-08 - Decided not to use
        /// <summary>
        /// Custom note in the Balikuj.cz system
        /// </summary>
        [JsonIgnore]
        public string Note { get; set; }

        /// <summary>
        /// Order ID
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Origin of the order
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Date of order payment
        /// </summary>
        public DateTime? PaidDate { get; set; }

        /// <summary>
        /// Information about the selected payment method
        /// </summary>
        public OrderPayment Payment { get; set; }

        /// <summary>
        /// Payment method price VAT
        /// </summary>
        public decimal? PaymentVat { get; set; }

        /// <summary>
        /// Payment method VAT rate
        /// </summary>
        public decimal? PaymentVatRate { get; set; }

        /// <summary>
        /// Payment method price without VAT
        /// </summary>
        public decimal? PaymentWithoutVat { get; set; }

        /// <summary>
        /// Payment method price with VAT
        /// </summary>
        public decimal? PaymentWithVat { get; set; }

        /// <summary>
        /// Number of shipment pieces (packages) according to the carrier's settings or custom settings in the order overview. Used to supplement the required values of individual carriers in automated label printing.
        /// </summary>
        public int? PieceCount { get; set; }

        /// <summary>
        /// Current picking status for the order
        /// </summary>
        public OrderPickingStatusEnum PickingStatus { get; set; }

        /// <summary>
        /// Picking date
        /// </summary>
        public DateTime? PickingDate { get; set; }

        /// <summary>
        /// Allows to mark the selected order or order items as resolved. Useful especially if not all items are shipped, etc.
        /// </summary>
        public bool Resolved { get; set; }

        /// <summary>
        /// Shipping VAT value
        /// </summary>
        public decimal? ShippingVat { get; set; }

        /// <summary>
        /// Shipping VAT rate
        /// </summary>
        public decimal? ShippingVatRate { get; set; }

        /// <summary>
        /// Shipping price without VAT
        /// </summary>
        public decimal? ShippingWithoutVat { get; set; }

        /// <summary>
        /// Shipping price with VAT
        /// </summary>
        public decimal? ShippingWithVat { get; set; }

        /// <summary>
        /// Information about the order status
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// ID of the warehouse
        /// </summary>
        public string StockId { get; set; }

        /// <summary>
        /// Total price rounded according to the application / customer settings
        /// </summary>
        public decimal TotalToPay { get; set; }

        /// <summary>
        /// Amount of VAT
        /// </summary>
        public decimal? TotalVat { get; set; }

        /// <summary>
        /// Total weight (in kg)
        /// </summary>
        public decimal? TotalWeight { get; set; }

        /// <summary>
        /// Total number of items in the order
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Total price with VAT without rounding
        /// </summary>
        public decimal? TotalWithoutVat { get; set; }

        /// <summary>
        /// Total price with VAT without rounding
        /// </summary>
        public decimal? TotalWithVat { get; set; }

        /// <summary>
        /// Date of last update
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Variable symbol
        /// </summary>
        public string Vs { get; set; }
    }
}
