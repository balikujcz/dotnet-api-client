using Balikuj.Client.Models.Addresses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Package
{
    public class Package
    {
        [JsonExtensionData] // Warning: Must use System.Text.Json as Newtonsoft didn't work and put items into an array
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// Can the shipment be canceled? Some shipments cannot be canceled because the carrier does not allow it.
        /// </summary>
        public bool CanCancel
        {
            get
            {
                return !Delivered && !Canceled && !Sent;
            }
            private set { }
        }

        /// <summary>
        /// Has the shipment been canceled?
        /// </summary>
        /// <example>false</example>
        public bool Canceled { get; set; }

        /// <summary>
        /// Carrier code
        /// </summary>
        /// <example>CP</example>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Carrier name
        /// </summary>
        /// <example>Česká pošta, s. p.</example>
        public string CarrierName { get; set; }

        /// <summary>
        /// Cash on delivery currency
        /// </summary>
        /// <example>CZK</example>
        public string CodCurrency { get; set; }

        /// <summary>
        /// Cash on delivery value
        /// </summary>
        /// <example>1000.00</example>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        /// <example>2024-01-15T08:48:27.83+01:00</example>
        public DateTime Created { get; set; }

        /// <summary>
        /// Is the shipment delivered?
        /// </summary>
        /// <example>false</example>
        public bool Delivered { get; set; }

        /// <summary>
        /// Indicates whether this shipment can be edited
        /// </summary>
        /// <example>false</example>
        public bool Editable { get; set; }

        public Address MaskAddress { get; set; }
        public int? MaskAddressId { get; set; }

        /// <summary>
        /// Order ID to which this shipment belongs
        /// </summary>
        /// <example>null</example>
        public int? OrderId { get; set; }

        /// <summary>
        /// Carrier package number
        /// GEIS = 7726000080212
        /// </summary>
        /// <example>DR0007700387M</example>
        public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Custom package naming (order number, etc.)
        /// </summary>
        /// <example>2024012345</example>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Package order number (for multi-package shipments)
        /// </summary>
        /// <example>1</example>
        public int PackageNumberOrder { get; set; }

        /// <summary>
        /// Shipment status ID according to the carrier
        /// </summary>
        public int PackageStatusId { get; set; }

        /// <summary>
        /// Number of packages in the shipment
        /// </summary>
        /// <example>1</example>
        public int PieceCount { get; set; }

        /// <summary>
        /// Package index (piece) in the shipment
        /// </summary>
        /// <example>1</example>
        public int PieceIndex { get; set; }

        /// <summary>
        /// Information about pickup
        /// </summary>
        /// <example>1274</example>
        public int? PickupId { get; set; }

        ///// <summary>
        ///// Has the pickup been created?
        ///// </summary>
        ///// <example>true</example>
        //public bool PickupCreated { get; set; }

        /// <summary>
        /// Declared shipment value
        /// </summary>
        /// <example>1000.00</example>
        public decimal Price { get; set; }

        /// <summary>
        /// Indicates whether a label can be printed for the shipment
        /// </summary>
        /// <example>true</example>
        public bool Printable { get; set; }

        /// <summary>
        /// Has a label for this shipment been printed?
        /// </summary>
        /// <example>true</example>
        public bool Printed { get; set; }

        /// <summary>
        /// Recipient address
        /// </summary>
        public Address RecAddress { get; set; }
        public int RecAddressId { get; set; }

        /// <summary>
        /// Shipment reference
        /// </summary>
        /// <example>Eshop order 0124515</example>
        public string Reference { get; set; }

        public Address SenderAddress { get; set; }
        public int? SenderAddressId { get; set; }

        /// <summary>
        /// Is the shipment sent - has there been any movement on it?
        /// </summary>
        /// <example>true</example>
        public bool Sent { get; set; }

        /// <summary>
        /// Carrier service code
        /// </summary>
        /// <example>DR</example>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Carrier service name
        /// </summary>
        /// <example>Balík Do ruky</example>
        public string ServiceName { get; set; }

        /// <summary>
        /// Last shipment status
        /// </summary>
        public PackageTrackingStatusEventResponse Status { get; set; }

        /// <summary>
        /// Indicates whether the shipment was inserted into the carrier's system. If false, it means the shipment is created in our system, a shipment ID has been reserved for it, but it has not yet been inserted into the carrier's system. Some carriers directly insert shipments into their system, others do not.
        /// </summary>
        /// <example>true</example>
        public bool SubmittedCarrier { get; set; }


        /// <summary>
        /// Indicates whether this is the main shipment or an item of a multi-package shipment
        /// </summary>
        /// <example>false</example>
        [DefaultValue(true)]
        public bool IsMaster { get; set; }

        /// <summary>
        /// ID of the main shipment to which this shipment belongs. If the shipment is main, this ID is null.
        /// </summary>
        /// <example>12354</example>
        [DefaultValue(null)]
        public int? MasterId { get; set; }

        /// <summary>
        /// Can this shipment be tracked?
        /// </summary>
        /// <example>true</example>
        public bool Trackable { get; set; }

        /// <summary>
        /// Date of last modification
		/// </summary>
		/// <example>2024-01-15T08:48:27.83+01:00</example>
		public DateTime Updated { get; set; }

        /// <summary>
        /// Variable symbol of cash on delivery
        /// </summary>
        /// <example>1234567890</example>
        public string Vs { get; set; }
    }
}
