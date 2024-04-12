using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.EmailTemplate
{
    public class MessageTemplate
    {
        /// <summary>
        /// Id of the email template
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Allowed tokens for the email template
        /// </summary>
        public string AllowedTokens { get; set; }

        /// <summary>
        /// Name of the email template
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email addresses for BCC
        /// </summary>
        public string BccEmailAddresses { get; set; }

        /// <summary>
        /// Subject of the email template
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Body of the email template, can be also HTML
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Is the email template active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Should the email be sent immediately
        /// </summary>
        public bool SendImmediately { get; set; }

        /// <summary>
        /// Delay before sending the email in seconds
        /// </summary>
        public int? DelayBeforeSend { get; set; }

        /// <summary>
        /// Id of the delay period
        /// </summary>
        public int DelayPeriodId { get; set; }

        /// <summary>
        /// Does the email template have an attached download
        /// </summary>
        public bool HasAttachedDownload { get; set; }

        /// <summary>
        /// Name of the attached download
        /// </summary>
        public string AttachedDownloadName { get; set; }

        /// <summary>
        /// Id of the email account
        /// </summary>
        public int EmailAccountId { get; set; }
    }
}
