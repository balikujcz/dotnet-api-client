namespace Balikuj.Client.Models.Webhooks
{
    public class WebhookEvent
    {
        /// <summary>
        /// Webhook event name
        /// </summary>
        /// <example>package:create</example>
        public string Name { get; set; }

        /// <summary>
        /// Webhook event description
        /// </summary>
        public string Description { get; set; }
    }
}
