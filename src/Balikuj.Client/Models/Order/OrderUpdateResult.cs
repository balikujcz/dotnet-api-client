using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderUpdateResult
    {
        /// <summary>
        /// Order ID
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Order number
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Says if the operation was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Messages
        /// </summary>
        public IList<string> Messages { get; set; }
    }
}
