using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderCreatePackageRequest
    {
        /// <summary>
        /// List of order IDs for which we want to create shipments according to the default settings
		/// </summary>
		public List<int> Orders { get; set; }
    }
}
