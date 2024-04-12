using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Label
{
    public class Label
    {
        /// <summary>
        /// Code of the carrier
		/// </summary>
		public string CarrierCode { get; set; }

        /// <summary>
        /// Name of the carrier
        /// </summary>
        public string CarrierName { get; set; }

        /// <summary>
        /// Link to download labels
        /// </summary>
        public string LabelsUrl { get; set; }

        /// <summary>
        /// Number of shipments for which labels are printed
        /// </summary>
        public int LabelsCount { get; set; }

        /// <summary>
        /// Unique Hash of the print job
        /// </summary>
        public string Hash { get; set; }
    }
}
