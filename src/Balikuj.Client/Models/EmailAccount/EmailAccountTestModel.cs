using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.EmailAccount
{
    public class EmailAccountTestModel
    {
        /// <summary>
        /// Id of the email account
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Email address of the recipient
        /// </summary>
        public string SendToEmail { get; set; }
    }
}
