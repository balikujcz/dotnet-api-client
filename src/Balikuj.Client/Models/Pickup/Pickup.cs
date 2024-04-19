using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Pickup
{
    public class Pickup
    {
        /// <summary>
        /// Unique hash for printing
		/// </summary>
		public string Hash { get; set; }

        /// <summary>
        /// Date of the pickup order
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Code of the carrier
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Printed date 
        /// </summary>
        public DateTime? Printed { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Number of packages in the handover protocol
        /// </summary>
        public int PackagesCount { get; set; }

        /// <summary>
        /// Url to the handover protocol
        /// </summary>
        public string ProtocolUrl { get; set; }

        /// <summary>
        /// Url to the labels
        /// </summary>
        public string LabelsUrl { get; set; }
    }
}
