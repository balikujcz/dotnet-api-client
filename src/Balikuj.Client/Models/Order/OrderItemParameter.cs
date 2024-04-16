using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderItemParameter
    {
        /// <summary>
        /// Code of the parameter
		/// </summary>
		public string Code { get; set; }

        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the parameter
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Value, if entered
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Price of the parameter
        /// </summary>
        public decimal Price { get; set; }
    }
}
