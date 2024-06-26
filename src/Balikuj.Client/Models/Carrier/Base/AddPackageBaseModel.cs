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

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Balikuj.Client.Converters;

namespace Balikuj.Client.Models.Carrier.Base
{
    public class AddPackageBaseModel
    {
        [JsonExtensionData]
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// ID of the order to which the shipment belongs
        /// </summary>
        public int? OrderId { get; set; }

        /// <summary>
        /// Code of the carrier service to be used for the shipment
        /// </summary>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string ServiceType { get; set; }

        /// <summary>
        /// First name and last name of the recipient
        /// </summary>
        public string RecName { get; set; }

        /// <summary>
        /// Name of the recipient company
        /// </summary>
        public string RecCompany { get; set; }

        /// <summary>
        /// Name of the recipient street
        /// </summary>
        public string RecStreet { get; set; }

        /// <summary>
        /// Name of the recipient city
        /// </summary>
        public string RecCity { get; set; }

        /// <summary>
        /// ZIP code of the recipient
        /// </summary>
        public string RecZip { get; set; }

        /// <summary>
        /// Code of the recipient's country in ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <remarks>
        /// Example: CZ for the Czech Republic
        /// </remarks>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string RecCountry { get; set; }

        /// <summary>
        /// Phone number of the recipient including the prefix in the format +AAACCCEEEGGG
        /// </summary>
        public string RecPhone { get; set; }

        /// <summary>
        /// Email of the recipient
        /// </summary>
        public string RecEmail { get; set; }

        /// <summary>
        /// Cover address entered?
        /// </summary>
        public bool? CoverEnabled { get; set; } = false;

        /// <summary>
        /// First name and last name of the cover address
        /// </summary>
        public string CoverName { get; set; }

        /// <summary>
        /// Name of the cover company
        /// </summary>
        public string CoverCompany { get; set; }

        /// <summary>
        /// Name of the cover street
        /// </summary>
        public string CoverStreet { get; set; }

        /// <summary>
        /// Name of the cover city
        /// </summary>
        public string CoverCity { get; set; }

        /// <summary>
        /// ZIP code of the cover address
        /// </summary>
        public string CoverZip { get; set; }

        /// <summary>
        /// Code of the cover address country in ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <remarks>
        /// For example, CZ for the Czech Republic
        /// </remarks>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string CoverCountry { get; set; }

        /// <summary>
        /// Phone number of the cover address including the prefix in the format +AAACCCEEEGGG
        /// </summary>
        public string CoverPhone { get; set; }

        /// <summary>
        /// Email of the cover address
        /// </summary>
        public string CoverEmail { get; set; }


        /// <summary>
        /// Was the sender's address entered?
        /// </summary>
        public bool? SenderEnabled { get; set; } = false;

        /// <summary>
        /// First name and last name of the sender
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// Name of the sender's company
        /// </summary>
        public string SenderCompany { get; set; }

        /// <summary>
        /// Name of the sender's street
        /// </summary>
        public string SenderStreet { get; set; }

        /// <summary>
        /// name of the sender's city
        /// </summary>
        public string SenderCity { get; set; }

        /// <summary>
        /// ZIP code of the sender's address
        /// </summary>
        public string SenderZip { get; set; }

        /// <summary>
        /// Code of the sender's address country in ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <remarks>
        /// For example, CZ for the Czech Republic
        /// </remarks>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string SenderCountry { get; set; }

        /// <summary>
        /// Phone number of the sender's address including the prefix in the format +AAACCCEEEGGG
        /// </summary>
        public string SenderPhone { get; set; }

        /// <summary>
        /// Email address of the sender
        /// </summary>
        public string SenderEmail { get; set; }
    }
}
