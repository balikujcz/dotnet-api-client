using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Package
{
    public class PackageTrackingStatusEventResponse
    {
        /// <summary>
        /// Date and time of the event
		/// </summary>
		public DateTime Date { get; set; }

        /// <summary>
        /// Category of the event
        /// </summary>
        /// <example>Delivered</example>
        public string Category { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sytem name of the event
        /// </summary>
        /// <example>Doručeno</example>
        public string NameSystem { get; set; }

        /// <summary>
        /// Type of event
        /// </summary>
        public PackageTrackingStatusType Type { get; set; }

        /// <summary>
        /// ID item - if exists, for multiple packages in one shipment
        /// </summary>
        public string Item { get; set; } = null;

        /// <summary>
        /// Informantion if the package was delivered
        /// </summary>
        public bool Delivered { get; set; } = false;

        /// <summary>
        /// Information if the package was canceled
        /// </summary>
        public bool Canceled { get; set; } = false;

        /// <summary>
        /// Status code returned by the carrier
        /// </summary>
        public string CarrierCode { get; set; }
    }
}
