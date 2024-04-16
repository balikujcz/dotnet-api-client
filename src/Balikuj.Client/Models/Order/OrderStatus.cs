using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderStatus
    {
        /// <summary>
        /// Order status ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the order status
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Text color of the selected order status
        /// </summary>
        public string TextColor { get; set; } = null;

        /// <summary>
        /// Background color of the selected order status
        /// </summary>
        public string BackgroundColor { get; set; } = null;

        /// <summary>
        /// Information whether it is a system status. System statuses cannot be deleted, only external status codes can be mapped to them.
        /// </summary>
        public bool IsSystem { get; set; }

        ///// <summary>
        ///// Information whether the status is editable. System statuses are fixed, they have an ID <= 0 and cannot be edited. Also, it is not yet possible to edit statuses loaded from Eshop applications.
        ///// Such statuses must always be edited in the settings of the respective eshop. This property is read-only and cannot be changed.
        ///// </summary>
        //public bool Editable { get; set; } = false;

        /// <summary>
        /// Display order of this status code
        /// </summary>
        public int DisplayOrder { get; set; }

    }
}
