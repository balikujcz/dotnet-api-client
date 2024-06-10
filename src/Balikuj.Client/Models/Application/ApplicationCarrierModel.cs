using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Application
{
    public class ApplicationCarrierModel
    {
        /// <summary>
		/// ID of order status
		/// </summary>
		public int Id { get; set; }

        /// <summary>
        /// ID of the application to which the status belongs
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Code of the status code from the source system. It can be a number or text. The value is then adjusted according to the target system.
        /// </summary>
        public string[] SourceId { get; set; }

        /// <summary>
        /// Name of the order status
        /// </summary>
        public string Name { get; set; }

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
