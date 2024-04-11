using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Webhooks
{
    public class WebhookCreateResponse
    {
        /// <summary>
        /// List of output objects (webhooks) that were created
		/// </summary>
		public List<WebhookDetail> Webhooks { get; set; } = new List<WebhookDetail>();

        /// <summary>
        /// List of addresses and errors that were not processed
        /// </summary>
        public List<WebhookCreateErrorModel> Errors { get; set; }

    }
}
