using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.EmailAccount
{
    public class EmailAccount
    {
        public int Id { get; set; }
        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Host, e.g. smtp.email.cz
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port, e.g. 587
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Your username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Your password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Enable SSL
        /// </summary>
        public bool EnableSsl { get; set; }

        //public bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// Sets if you want to use this email account as default
        /// </summary>
        public bool IsDefaultEmailAccount { get; set; }
    }
}
