using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Pickup
{
    public class PickupOrderResultModel
    {
        /// <summary>
        /// ID of the pickup order in the system. Each carrier has its own unique number for pickup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Address of the delivery protocol in PDF for download.
        /// </summary>
        public string ProtocolUrl { get; set; }

        /// <summary>
        /// Address for downloading all shipment labels in PDF.
        /// </summary>
        public string LabelsUrl { get; set; }

        /// <summary>
        /// Number of packages that were inserted into the system.
        /// </summary>
        public int PackagesCount { get; set; } = 0;
    }
}

