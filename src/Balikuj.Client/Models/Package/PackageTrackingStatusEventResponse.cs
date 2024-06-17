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

namespace Balikuj.Client.Models.Package
{
    public class PackageTrackingStatusEventResponse
    {
        /// <summary>
        /// Date and time of the event
		/// </summary>
		public DateTime Date { get; set; }

        /// <summary>
        /// Category of the event
        /// </summary>
        /// <example>Delivered</example>
        public string Category { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sytem name of the event
        /// </summary>
        /// <example>Doručeno</example>
        public string NameSystem { get; set; }

        /// <summary>
        /// Type of event
        /// </summary>
        public PackageTrackingStatusType Type { get; set; }

        /// <summary>
        /// ID item - if exists, for multiple packages in one shipment
        /// </summary>
        public string Item { get; set; } = null;

        /// <summary>
        /// Informantion if the package was delivered
        /// </summary>
        public bool Delivered { get; set; } = false;

        /// <summary>
        /// Information if the package was canceled
        /// </summary>
        public bool Canceled { get; set; } = false;

        /// <summary>
        /// Status code returned by the carrier
        /// </summary>
        public string CarrierCode { get; set; }
    }
}
