namespace Balikuj.Client.Models.Account
{
    public class AccountLoginRequest
    {
        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Login language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Two-factor authentication code
        /// </summary>
        public string Code { get; set; }
    }
}
