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

using System.Collections.Generic;

namespace Balikuj.Client.Models.Carrier
{
    public class PackageTrackingStatusResponseModel
    {
        /// <summary>
        /// Number of the package carrier
		/// </summary>
		/// <example>DR28103873681</example>
		public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Status code of the package
        /// </summary>
        /// <example>200</example>
        public int StatusCode { get; set; } = 200;

        /// <summary>
        /// Status message of the package
        /// </summary>
        /// <example>OK</example>
        public string Message { get; set; } = "OK";

        /// <summary>
        /// List of events in tracking statuses for the given shipment
        /// </summary>
        public IList<PackageTrackingStatusEventResponseModel> Events { get; set; }
    }
}
