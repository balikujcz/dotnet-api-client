using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier
{
    public class PackageTrackingStatusResponseModel
    {
        /// <summary>
        /// Number of the package carrier
		/// </summary>
		/// <example>DR28103873681</example>
		public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Status code of the package
        /// </summary>
        /// <example>200</example>
        public int StatusCode { get; set; } = 200;

        /// <summary>
        /// Status message of the package
        /// </summary>
        /// <example>OK</example>
        public string Message { get; set; } = "OK";

        /// <summary>
        /// List of events in tracking statuses for the given shipment
        /// </summary>
        public IList<PackageTrackingStatusEventResponseModel> Events { get; set; }
    }
}
