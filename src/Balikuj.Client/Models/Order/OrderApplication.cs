using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderApplication
    {
        /// <summary>
        /// ID of the application in which the order was created
		/// </summary>
		public int Id { get; set; }

        /// <summary>
        /// Domain of the application in which the order was created
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Code of the application type
        /// </summary>
        public string Code { get; set; }
    }
}

