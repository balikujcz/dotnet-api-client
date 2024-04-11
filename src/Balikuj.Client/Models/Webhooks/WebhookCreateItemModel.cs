namespace Balikuj.Client.Models.Webhooks
{
    public class WebhookCreateItemModel
    {
        /// <summary>
        /// Name of an event
        /// </summary>
        /// <example>package:create</example>
        /// 
        public string Event { get; set; }

        /// <summary>
        /// URL address
        /// </summary>
        /// <example>https://www.yourdomain.com/path</example>

        public string Url { get; set; }
    }
}
