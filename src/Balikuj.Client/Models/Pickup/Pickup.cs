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

using Balikuj.Client.Models.Base;
using System;

namespace Balikuj.Client.Models.Pickup
{
    public class Pickup : BaseEntityModel
    {
        /// <summary>
        /// Unique hash for printing
		/// </summary>
		public string Hash { get; set; }

        /// <summary>
        /// Date of the pickup order
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Code of the carrier
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Printed date 
        /// </summary>
        public DateTime? Printed { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Number of packages in the handover protocol
        /// </summary>
        public int PackagesCount { get; set; }

        /// <summary>
        /// Url to the handover protocol
        /// </summary>
        public string ProtocolUrl { get; set; }

        /// <summary>
        /// Url to the labels
        /// </summary>
        public string LabelsUrl { get; set; }
    }
}
