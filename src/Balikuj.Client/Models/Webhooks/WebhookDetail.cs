using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Webhooks
{
    public class WebhookDetail
    {
        /// <summary>
		/// ID of the webhook
		/// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        /// <example>package:create</example>
        public string Event { get; set; }

        /// <summary>
        /// URL address
        /// </summary>
        /// <example>https://www.yourdomain.com/path</example>
        public string Url { get; set; }

        /// <summary>
        /// Date of creation
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date of last update
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Webhook status
        /// </summary>
        /// <example>Active</example>
        public WebhookStatus Status { get; set; }
    }
}
