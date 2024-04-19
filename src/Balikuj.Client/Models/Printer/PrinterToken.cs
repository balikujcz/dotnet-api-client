using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Printer
{
    public class PrinterToken
    {
        /// <summary>
        /// ID of the token
		/// </summary>
		public string Token { get; set; }

        /// <summary>
        /// Description of the token - for example location
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Date of token creation
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date of the last token change
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Is the token currently connected?
        /// </summary>
        public bool IsConnected { get; set; }

        /// <summary>
        /// Date of the last connection of the service to the document printing
        /// </summary>
        public DateTime? LastConnected { get; set; }
    }
}
