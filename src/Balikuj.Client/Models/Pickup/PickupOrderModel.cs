using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Pickup
{
    public class PickupOrderModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Optional pickup date when the shipment should be picked up
        /// 
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// List of shipment IDs in our system
        /// </summary>
        /// <example>[ 121, 122, 123 ]</example>
        public List<int> Packages { get; set; }
    }
}
