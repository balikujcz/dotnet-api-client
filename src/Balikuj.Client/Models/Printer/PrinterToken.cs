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
