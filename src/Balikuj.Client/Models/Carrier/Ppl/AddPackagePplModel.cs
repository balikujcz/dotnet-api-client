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

using Balikuj.Client.Models.Carrier.Base;

namespace Balikuj.Client.Models.Carrier.Ppl
{
    public class AddPackagePplModel : AddPackageBaseModel, IAddPackageModel
    {
        /// <summary>
        /// Reference number/ID of the shipment
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Number of packages in the shipment
        /// </summary>
        public int PieceCount { get; set; }

        /// Balikuj currently only supports depot-weighted shipments
        /// If someone wanted to, it would have to be redesigned, as in DPD, and the weight of individual packages would be specified in the UI
        /// Currently, PPL requires the weight of each package to be specified

        /// <summary>
        /// Total weight of the shipment in kg
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Custom note when inserting a package into the database
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Declared value of the shipment
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// ID of the branch. The list of branches can be obtained through the method {{carrier}}/Branches
        /// </summary>
        public string BranchId { get; set; }

        /// <summary>
        /// Cash on delivery value. Sets the total value for the entire shipment and only for the first item
        /// </summary>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Currency of the cash on delivery
        /// </summary>
        public string CodCurrency { get; set; }

        /// <summary>
        /// Variable symbol of the cash on delivery
        /// </summary>
        /// <example>0123456789</example>
        public string Vs { get; set; }

        /// <summary>
        /// IBAN
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// Swift
        /// </summary>
        public string Swift { get; set; }

        /// <summary>
        /// Bank account number
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Bank code
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// Age verification of the recipient. Possible values are 15 = 15+ and 18 = 18+
        /// </summary>
        public string AgeCheck { get; set; }

        public bool? AllowNextDelivery { get; set; }

        /// <summary>
        /// Insurance amount
        /// </summary>
        public bool? Insurance { get; set; }

        public decimal? InsurancePrice { get; set; }

        public string InsuranceCurrency { get; set; }

        /// <summary>
        /// Custom naming of the shipment (order number, etc.)
        /// Only numbers (0-9), letters (a-z, A-Z), hyphen (-), slash (/), underscore (_) are allowed
        /// Maximum length of 30 characters
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Package order number (for multi-package shipments)
        /// </summary>
        public int? PackageNumberOrder { get; set; }

        /// <summary>
        /// Date of collection of the shipment or sending of the order in the format YYYY-MM-DD.
        /// </summary>
        /// <example>2024-02-20</example>
        public string PickupDate { get; set; }

        /// <summary>
        /// Specifies whether the Return shipment should be picked up directly from the customer by the driver (for a fee)
        /// </summary>
        public bool? PickupCarrier { get; set; }
    }
}
