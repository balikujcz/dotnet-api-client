/*
* Copyright (c) 2024 Balíkuj.cz
* http://balikuj.cz
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

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
