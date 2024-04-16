using System;
using System.Collections.Generic;
using System.Text;
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
