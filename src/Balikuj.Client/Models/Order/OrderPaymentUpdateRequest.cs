using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderPaymentUpdateRequest
    {
        /// <summary>
        /// Code of payment method from source system. It can be a number or text. The value is then adjusted according to the target system.
		/// </summary>
		public string[] SourceId { get; set; }

        /// <summary>
        /// Name of payment method
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Informations whether it is a system payment method. System payment methods cannot be deleted, only external payment methods can be mapped to SourceId.
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Path to the logo/image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Order of display of this status code
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
