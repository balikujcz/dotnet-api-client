﻿/*
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
using Balikuj.Client.Models.Carrier.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier.Cp
{
    public class AddPackageCpModel : AddPackageBaseModel, IAddPackageModel
    {
        /// <summary>
        /// Reference number/ID of the package.
        /// </summary>
        /// <example>Reference balíku</example>
        public string Reference { get; set; }

        /// <summary>
        /// Total weight of the package in kg
        /// </summary>
        /// <example>1.5</example>
        public decimal Weight { get; set; }

        /// <summary>
        /// Note for the carrier (maximum length 50 characters). Will be printed on the label.
        /// </summary>
        /// <example>Please, dont open</example>
        public string Note { get; set; }

        /// <summary>
        /// Value of the package. Service code = 7 is added automatically to the package that supports it.
        /// </summary>
        /// <example>1000.50</example>
        public decimal Price { get; set; }

        /// <summary>
        /// ID of pickup point. List of pickup points can be obtained via the Branches method
        /// </summary>
        /// <example>CZ10037</example>
        public string BranchId { get; set; }

        /// <summary>
        /// Value of the cash on delivery in CZK. Can be a decimal number.
        /// </summary>
        /// <example>1000.50</example>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Currency of the cash on delivery in ISO 4217 format (CZK). Only "CZK" is supported so far.
        /// </summary>
        /// <example>CZK</example>
        public string CodCurrency { get; set; }

        /// <summary>
        /// Variable symbol of the cash on delivery, mandatory for cash on delivery shipments
        /// </summary>
        /// <example>1234567890</example>
        public string Vs { get; set; }

        /// <summary>
        /// Width in cm - mandatory for BN service type
        /// </summary>
        /// <example>20.0</example>
        public decimal? Width { get; set; }

        /// <summary>
        /// Height in cm - mandatory for BN service type
        /// </summary>
        /// <example>30.0</example>
        public decimal? Height { get; set; }

        /// <summary>
        /// Length in cm - mandatory for BN service type
        /// </summary>
        /// <example>55.0</example>
        public decimal? Length { get; set; }

        /// <summary>
        /// Codes of additional services. List of supported service codes can be found in the documentation at https://docs.balikuj.cz
        /// </summary>
        /// <example>["1", "3"]</example>
        [JsonConverter(typeof(UpperCaseListStringJsonConverter))]
        public List<string> Services { get; set; }

        /// <summary>
        /// Size of the package for services that require a size category (S, M, L, XL)
        /// </summary>
        /// <example>S</example>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string Size { get; set; }

        /// <summary>
        /// Value of the insurance in CZK. If not filled, the value of Price will be used
        /// </summary>
        /// <example>1000.50</example>
        public decimal? InsurancePrice { get; set; }

        /// <summary>
        /// Currency of the insurance, only "CZK" is supported so far
        /// </summary>
        /// <example>CZK</example>
        public string InsuranceCurrency { get; set; }

        /// <summary>
        /// Own naming of the shipment (order number, etc.)
        /// Accessible characters are only numbers (0-9), letters (a-z, A-Z), hyphen (-), slash (/), underscore (_)
        /// Max length is 30 characters
        /// </summary>
        /// <example>1234567890</example>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Order number of the package (for multi-package shipments)
        /// </summary>
        /// <example>1</example>
        public int? PackageNumberOrder { get; set; }
    }
}
