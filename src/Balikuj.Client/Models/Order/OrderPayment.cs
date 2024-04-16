using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderPayment
    {
        /// <summary>
        /// ID of the payment method
		/// </summary>
		public int Id { get; set; }

        /// <summary>
        /// name of the payment method
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Information, whether it is a system payment method. System payment methods cannot be deleted, only external payment methods can be mapped to SourceId.
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// URL to the logo/image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Listing order of this status code
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
