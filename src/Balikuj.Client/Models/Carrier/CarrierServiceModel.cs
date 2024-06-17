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

using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierServiceModel
    {
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Service code of the carrier - used for pairing carrier services with shipments and orders
        /// </summary>
        /// <example>ParcelConnect</example>
        public string Code { get; set; }

        /// <summary>
        /// Name of the carrier service
        /// </summary>
        /// <example>PPL Parcel Connect</example>
        public string Name { get; set; }

        /// <summary>
        /// Information about whether the service supports cover addresses
        /// </summary>
        /// <example>False</example>
        public bool CoverAddressEnabled { get; set; }


        /// <summary>
        /// Information about whether the service can be sent from an address other than the collection address
        /// </summary>
        /// <example>False</example>
        public bool SenderAddressEnabled { get; set; }
    }
}
