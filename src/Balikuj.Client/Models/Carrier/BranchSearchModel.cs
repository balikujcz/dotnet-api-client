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

using Balikuj.Client.Converters;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier
{
    public class BranchSearchModel
    {
        /// <summary>
        /// Type of branch, Branch = Branch, Box = Pickup box
        /// </summary>
        /// <example>Branch</example>
        public CarrierBranchType? BranchType { get; set; }

        /// <summary>
        /// ISO country code (2 characters) for filtering the list of branches
        /// </summary>
        /// <example>CZ</example>
        public string Country { get; set; }

        /// <summary>
        /// Single keyword without spaces for searching in name, city, or street
        /// </summary>
        /// <example>Brno</example>
        public string Name { get; set; }

        /// <summary>
        /// Carrier service code to be used for the shipment
        /// </summary>
        /// <example>NP</example>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string ServiceType { get; set; }

        /// <summary>
        /// Carrier ID to search for branches. This option is currently only used for Zásilkovna (PACKETA) to return carrier pickup points
        /// </summary>
        public string SubCarrierId { get; set; }
    }
}
