using System;

namespace Balikuj.Client.Models.Account
{
    public class AccountLoginResponse
    {
        /// <summary>
        /// Auth token for further requests
        /// </summary>
        /// <example>285A1DAE198E75771BD78A7DAF1782DD47BFB7E968A5983A3585B9CFC2914F0507A3DE257CDC87CDCAD808CB34CD05DA47D9EB7C9D8B987550B11921DECC66D4</example>
        public string AuthToken { get; set; }

        /// <summary>
        /// Datetime when the token expires
        /// </summary>
        /// <example>2023-12-12T13:01:13.5878022+01:00</example>
        public DateTime ExpiresIn { get; set; }
    }
}
