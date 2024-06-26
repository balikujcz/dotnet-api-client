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

using Balikuj.Client.Models.Carrier.Base;

namespace Balikuj.Client.Models.Carrier.Dpd
{
    public class AddPackageDpdModel : AddPackageBaseModel, IAddPackageModel
    {
        /// <summary>
        /// Reference number/shipment ID. Maximum 35 characters.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Reference number/shipment ID
        /// </summary>
        public string Reference2 { get; set; }

        /// <summary>
        /// Total weight of the shipment in kg
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Carrier note (maximum length 64 characters).
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Declared value of the shipment
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Branch ID. The list of branches can be obtained through the Branches method
        /// </summary>
        public string BranchId { get; set; }

        /// <summary>
        /// Cash on delivery value. Can be a decimal number.
        /// </summary>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Cash on delivery currency in ISO 4217 format (CZK)
        /// </summary>
        public string CodCurrency { get; set; }

        //CASH or CASH_OR_CARD
        /// <summary>
        /// Flag indicating whether cash on delivery can be paid by card. The default value is true = card payment is possible
        /// </summary>
        public bool? CreditCard { get; set; }

        /// <summary>
        /// Bank code
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// Bank name
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Bank account number
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        public string BankAccountName { get; set; }

        /// <summary>
        /// Variable symbol for cash on delivery, mandatory for cash on delivery shipments
        /// </summary>
        public string Vs { get; set; }

        /// <summary>
        /// Bank account number in IBAN format
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// Bank account number in IBAN format
        /// </summary>
        public string Swift { get; set; }


        /// <summary>
        /// Information whether the Swap service will be added. If set to true, the same number of swap shipments will be created as the number of packages in the shipment (swapCount = pieceCount). This is a limitation of the DPD API.
        /// </summary>
        public bool? ExchangeOrder { get; set; }

        /// <summary>
        /// SMS notification before delivery
        /// </summary>
        public bool? SmsNotification { get; set; }

        /// <summary>
        /// Insurance value, only send for shipments over 50,000 CZK. This value is set for each package included in the shipment.
        /// </summary>
        public decimal? InsurancePrice { get; set; }

        /// <summary>
        /// Insurance currency, currently only default currency "CZK" is supported
        /// </summary>
        public string InsuranceCurrency { get; set; }

        /// <summary>
        /// Custom name of the shipment (order number, etc.)
        /// Only numbers (0-9), letters (a-z, A-Z), hyphen (-), slash (/), underscore (_) are allowed
        /// Maximum length of 30 characters
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Package number (for multi-package shipments)
        /// </summary>
        public int? PackageNumberOrder { get; set; }

        /// <summary>
        /// The shipment will be delivered to the Recipient only upon presentation of the original identity document. The Recipient's name must be provided for identity verification.
        /// </summary>
        public bool? Authentication { get; set; }

        /// <summary>
        /// Recipient's identity verification
        /// </summary>
        public string AuthenticationName { get; set; }

        /// <summary>
        /// Recipient's identification document number. Optional and used only if you fill in the AuthenticationName value.
        /// </summary>
        public string AuthenticationId { get; set; }
    }
}
