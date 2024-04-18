using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderItemUpdateResponse
    {
        public int OrderItemId { get; set; }

        public bool Success { get; set; }

        public IList<string> Messages { get; set; }
    }
}
