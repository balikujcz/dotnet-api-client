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

namespace Balikuj.Client.Models.Application
{
    public class ApplicationCarrierModel
    {
        /// <summary>
		/// ID of order status
		/// </summary>
		public int Id { get; set; }

        /// <summary>
        /// ID of the application to which the status belongs
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Code of the status code from the source system. It can be a number or text. The value is then adjusted according to the target system.
        /// </summary>
        public string[] SourceId { get; set; }

        /// <summary>
        /// Name of the order status
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Code of the carrier
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Name of the carrier
        /// </summary>
        public string CarrierName { get; set; }

        /// <summary>
        /// Code of the carrier service
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Name of the carrier service
        /// </summary>
        public string ServiceName { get; set; }
    }
}
