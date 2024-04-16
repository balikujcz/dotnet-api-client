using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Order
{
    public class OrderItem
    {
        [JsonExtensionData] // Warning must be System.Text.Json, as Newtonsoft did not work and put items into an array
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// Availability of the product at the time it was ordered
        /// </summary>
        public string Availability { get; set; }

        /// <summary>
        /// VAT on purchase price
        /// </summary>
        public decimal? BuyPriceVat { get; set; }

        /// <summary>
        /// VAT rate on purchase price
        /// </summary>
        public decimal? BuyPriceVatRate { get; set; }

        /// <summary>
        /// Purchase price without VAT
        /// </summary>
        public decimal? BuyPriceWithoutVat { get; set; }

        /// <summary>
        /// Purchase price with VAT
        /// </summary>
        public decimal? BuyPriceWithVat { get; set; }

        /// <summary>
        /// Product code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// EAN code of the product
        /// </summary>
        public string Ean { get; set; }

        /// <summary>
        /// Image address
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// VAT of the item
        /// </summary>
        public decimal? ItemPriceVat { get; set; }

        /// <summary>
        /// VAT rate of the item
        /// </summary>
        public decimal? ItemPriceVatRate { get; set; }

        /// <summary>
        /// Item price without VAT
        /// </summary>
        public decimal? ItemPriceWithoutVat { get; set; }

        /// <summary>
        /// Item price with VAT
        /// </summary>
        public decimal? ItemPriceWithVat { get; set; }

        /// <summary>
        /// Product type
        /// </summary>
        public OrderItemTypeEnum ItemType { get; set; }

        /// <summary>
        /// JSON data
        /// </summary>
        public string JsonData { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Item parameters
        /// </summary>
        public IList<OrderItemParameter> Parameters { get; set; }

        /// <summary>
        /// Number of items that were picked
        /// </summary>
        public int PickedQuantity { get; set; }

        /// <summary>
        /// Unique product identifier
        /// </summary>
        public string ProductGuid { get; set; }

        /// <summary>
        /// Quantity of units
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Recycling fee
        /// </summary>
        public decimal? RecyclingFee { get; set; }

        /// <summary>
        /// Indicates whether the item was resolved/picked
        /// </summary>
        public bool Resolved { get; set; }

        /// <summary>
        /// Stock location
        /// </summary>
        public string StockLocation { get; set; }

        /// <summary>
        /// VAT for all items
        /// </summary>
        public decimal TotalVat { get; set; }

        /// <summary>
        /// Total price for all items without VAT
        /// </summary>
        public decimal TotalWithoutVat { get; set; }

        /// <summary>
        /// Total price for all items with VAT
        /// </summary>
        public decimal TotalWithVat { get; set; }

        /// <summary>
        /// Product unit
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Variant name
        /// </summary>
        public string VariantName { get; set; }

        /// <summary>
        /// Product weight (in kg)
        /// </summary>
        public decimal? Weight { get; set; }

    }
}
