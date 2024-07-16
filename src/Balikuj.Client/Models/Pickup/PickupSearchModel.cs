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
using System.Collections.Generic;

namespace Balikuj.Client.Models.Pickup
{
    public class PickupSearchModel : BaseSearchModel
    {
        /// <summary>
        /// Carrier codes
        /// </summary>
        /// <example>["DPD", "PPL"]</example>
        public IList<string> CarrierCode { get; set; } = new List<string>();

        /// <summary>
        /// Date of creation from in the format YYYY-MM-DD
        /// </summary>
        /// <example>2024-01-10</example>
        public string CreatedFrom { get; set; }

        /// <summary>
        /// Date of creation to in the format YYYY-MM-DD
        /// </summary>
        /// <example>2024-01-14</example>
        public string CreatedTo { get; set; }

        /// <summary>
        /// Sort field name
        /// </summary>
        /// <example>created</example>
        public string SortField { get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        /// <example>desc</example>
        public string SortOrder { get; set; }
    }
}
