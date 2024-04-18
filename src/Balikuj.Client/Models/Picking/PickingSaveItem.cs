using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Picking
{
    public class PickingSaveItem
    {
        /// <summary>
        /// Order item id
        /// </summary>
        public int OrderItemId { get; set; }

        /// <summary>
        /// Picked quantity
        /// </summary>
        public int PickedQuantity { get; set; }
    }
}
