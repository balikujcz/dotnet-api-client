using System.ComponentModel;

namespace Balikuj.Client.Models.Account
{
    public class AccountInfoUpdateRequest
    {
        public string FullName { get; set; }

        public string Company { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        /// <summary>
        /// Country code ISO 3166-1 alpha-2
        /// </summary>
        public string Country { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        /// <summary>
        /// Time zone
        /// </summary>
        [DefaultValue("Central Europe Standard Time")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Account settings
        /// </summary>
        public AccountInfoSettings Settings { get; set; }
    }
}
