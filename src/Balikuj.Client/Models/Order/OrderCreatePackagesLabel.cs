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

namespace Balikuj.Client.Models.Order
{
    public class OrderCreatePackagesLabel
    {
        /// <summary>
        /// Carrier code
		/// </summary>
		public string CarrierCode { get; set; }

        /// <summary>
        /// Name of the carrier
        /// </summary>
        public string CarrierName { get; set; }

        /// <summary>
        ///  Number of packages successfully created by the carrier
        /// </summary>
        public int PackagesCount { get; set; }

        /// <summary>
        /// URL for downloading labels
        /// </summary>
        public string LabelsUrl { get; set; }

        /// <summary>
        /// Hash for printing labels
        /// </summary>
        public string LabelsHash { get; set; }

        /// <summary>
        /// Link to download orders in PDF sorted by the given carrier
        /// </summary>
        public string OrdersUrl { get; set; }

        /// <summary>
        /// hash for printing orders
        /// </summary>
        public string OrdersHash { get; set; }
    }
}
