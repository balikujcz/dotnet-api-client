using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Webhooks
{
    public class WebhookUpdateModel
    {
        /// <summary>
        /// ID of the record
		/// </summary>
        public int Id { get; set; }

        /// <summary>
        /// URL address 
        /// </summary>
        public string Url { get; set; }
    }
}
