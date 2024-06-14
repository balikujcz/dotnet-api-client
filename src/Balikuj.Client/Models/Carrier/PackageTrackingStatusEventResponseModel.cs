using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier
{
    public class PackageTrackingStatusEventResponseModel
    {
        /// <summary>
        /// Date and time of the event
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Event category
        /// </summary>
        /// <example>Delivered</example>
        public string Category { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// System name of the event
        /// </summary>
        /// <example>Delivered</example>
        public string NameSystem { get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        public PackageTrackingStatusTypeEnum Type { get; set; }

        /// <summary>
        /// Item ID - if exists, for multiple packages in one shipment
        /// </summary>
        public string Item { get; set; } = null;

        /// <summary>
        /// Information whether the shipment was delivered
        /// </summary>
        public bool Delivered { get; set; } = false;

        /// <summary>
        /// Information whether the shipment was canceled
        /// </summary>
        public bool Canceled { get; set; } = false;

        /// <summary>
        /// Tracking status code returned directly by the carrier
        /// </summary>
        public string CarrierCode { get; set; }
    }
}
