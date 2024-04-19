using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Printer
{
    public class PrinterPrint
    {
        /// <summary>
        /// Unique hash of print job
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// System printer in Balikuj system (printerName). Not the name of the printer itself (name).
        /// </summary>
        public string PrinterName { get; set; }
    }
}
