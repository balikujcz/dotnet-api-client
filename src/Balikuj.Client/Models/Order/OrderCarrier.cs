using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Order
{
    public class OrderCarrier
    {
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Code of the carrier
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Name of the carrier
        /// </summary>
        public string CarrierName { get; set; }

        /// <summary>
        /// Code of the carrier service
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Name of the carrier service
        /// </summary>
        public string ServiceName { get; set; }
    }
}
