using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderCreatePackagesResult
    {
        /// <summary>
        /// List of results of creating labels for individual orders
		/// </summary>
		public List<OrderCreatePackagesItem> Orders { get; set; } = new List<OrderCreatePackagesItem>();

        /// <summary>
        /// Labels for individual carriers
        /// </summary>
        public List<OrderCreatePackagesLabel> Labels { get; set; } = new List<OrderCreatePackagesLabel>();
    }
}
