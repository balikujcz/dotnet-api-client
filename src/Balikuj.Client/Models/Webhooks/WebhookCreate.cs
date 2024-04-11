using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Webhooks
{
    public class WebhookCreate
    {
        /// <summary>
		/// List of webhooks to create
		/// </summary>
		public List<WebhookCreateItemModel> Data { get; set; }
    }
}
