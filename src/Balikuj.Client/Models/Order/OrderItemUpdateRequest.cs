using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderItemUpdateRequest
    {
        /// <summary>
        /// List of item IDs for which we want to change the status
		/// </summary>
		public IList<int> Items { get; set; }

        /// <summary>
        /// Allows you to mark the item as resolved/unresolved
        /// </summary>
        public bool? Resolved { get; set; }
    }
}
