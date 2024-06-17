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

using System;

namespace Balikuj.Client.Models.Printer
{
    public class PrinterModel
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
