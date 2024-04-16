using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderCreatePackagesLabel
    {
        /// <summary>
        /// Carrier code
		/// </summary>
		public string CarrierCode { get; set; }

        /// <summary>
        /// Name of the carrier
        /// </summary>
        public string CarrierName { get; set; }

        /// <summary>
        ///  Number of packages successfully created by the carrier
        /// </summary>
        public int PackagesCount { get; set; }

        /// <summary>
        /// URL for downloading labels
        /// </summary>
        public string LabelsUrl { get; set; }

        /// <summary>
        /// Hash for printing labels
        /// </summary>
        public string LabelsHash { get; set; }

        /// <summary>
        /// Link to download orders in PDF sorted by the given carrier
        /// </summary>
        public string OrdersUrl { get; set; }

        /// <summary>
        /// hash for printing orders
        /// </summary>
        public string OrdersHash { get; set; }
    }
}
