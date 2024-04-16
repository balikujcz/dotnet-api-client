using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderUpdateRequest
    {
        /// <summary>
        /// List of orders we want to update. The maximum number of orders for update is 100.
		/// </summary>
		public List<OrderUpdateItem> Orders { get; set; }

        /// <summary>
        /// If filled in, it determines whether the corresponding documents will be generated when the status changes for the given e-shop platform. Not all e-shop applications/platforms support this function
        /// </summary>
        public bool? GenerateDocuments { get; set; }

        /// <summary>
        /// If filled in, it determines whether SMS messages will be generated when the order status changes. Setting according to the selected e-shop application/platform supporting this function
        /// </summary>
        public bool? GenerateSms { get; set; }

        /// <summary>
        /// If filled in, it determines whether email messages will be generated when the order status changes. Setting according to the selected e-shop application/platform supporting this function
        /// </summary>
        public bool? GenerateEmail { get; set; }
    }
}
