using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Printer
{
    public class Printer
    {
        /// <summary>
        /// Hostname of the computer
		/// </summary>
		public string ComputerName { get; set; }

        /// <summary>
        /// System name of the printer. Cannot be changed and is used for printing documents
        /// </summary>
        public string PrinterName { get; set; }

        /// <summary>
        /// Owner name of the printer. Can be changed and the printer will have this name in the system.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Printer status
        /// </summary>
        public PrinterStatus PrinterStatus { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Updated date
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Last activity date
        /// </summary>
        public DateTime? LastActivity { get; set; }
    }
}
