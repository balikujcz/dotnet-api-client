﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderStatusCreateRequest
    {

        /// <summary>
        /// Code of the status code from the source system. It can be a number or text. The value is then adjusted according to the target system.
        /// </summary>
        public string[] SourceId { get; set; }

        /// <summary>
        /// Name of the order status
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Color of the text of the selected order status
        /// </summary>
        public string TextColor { get; set; } = null;

        /// <summary>
        /// Color of the background of the selected order status
        /// </summary>
        public string BackgroundColor { get; set; } = null;

        /// <summary>
        /// Order of display of this status code
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}