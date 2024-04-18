using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Picking
{
    public class PickingSave
    {
        /// <summary>
        /// Picking items
        /// </summary>
        public List<PickingSaveItem> Items { get; set; }
    }
}
