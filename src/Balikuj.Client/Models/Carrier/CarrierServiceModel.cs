using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierServiceModel
    {
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Service code of the carrier - used for pairing carrier services with shipments and orders
        /// </summary>
        /// <example>ParcelConnect</example>
        public string Code { get; set; }

        /// <summary>
        /// Name of the carrier service
        /// </summary>
        /// <example>PPL Parcel Connect</example>
        public string Name { get; set; }

        /// <summary>
        /// Information about whether the service supports cover addresses
        /// </summary>
        /// <example>False</example>
        public bool CoverAddressEnabled { get; set; }


        /// <summary>
        /// Information about whether the service can be sent from an address other than the collection address
        /// </summary>
        /// <example>False</example>
        public bool SenderAddressEnabled { get; set; }
    }
}
