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
using System.ComponentModel;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierListResponse
    {
        /// <summary>
        /// Carrier name
        /// </summary>
        /// <example>PPL CZ s.r.o.</example>
        public string Name { get; set; }


        /// <summary>
        /// Carrier code - used for matching carriers in shipments and orders
        /// </summary>
        /// <example>PPL</example>
        public string Code { get; set; }


        /// <summary>
        /// Carrier description
        /// </summary>
        /// <example>PPL CZ package transport s.r.o.</example>
        public string Description { get; set; }


        /// <summary>
        /// Carrier activation date, if already activated
        /// </summary>
        /// <example>2023-11-30T16:57:35.646646</example>
        public DateTime? Activated { get; set; }


        /// <summary>
        /// Carrier status for the current user
        /// </summary>
        /// <example>Active</example>
        [DefaultValue(CustomerCarrierActivationStatus.Inactive)]
        public CustomerCarrierActivationStatus Status { get; set; }
    }
}
