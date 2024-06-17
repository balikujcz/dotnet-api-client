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
using System.Collections.Generic;
using System.ComponentModel;

namespace Balikuj.Client.Models.Carrier.Gls
{
    public class AddPackageGlsModel : AddPackageBaseModel, IAddPackageModel
    {
        /// <summary>
        /// Reference number/ID of the shipment
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Number of packages in the shipment
        /// </summary>
        /// <example>1</example>
        public int PieceCount { get; set; }

        /// <summary>
        /// Total weight of the shipment in kg. It is stated on the label. If not filled, the value will be 0
        /// </summary>
        /// <example>1.0</example>		
        public decimal? Weight { get; set; }

        /// <summary>
        /// Custom note when inserting the package into the database
        /// </summary>
        /// <example>Custom note</example>
        public string Note { get; set; }

        /// <summary>
        /// Declared value of the shipment
        /// </summary>
        /// <example>1000.0</example>
        public decimal Price { get; set; }

        /// <summary>
        /// ID of the branch. The list of branches can be obtained through the method {{carrier}}/Branches
        /// </summary>
        /// <example>VYDEJNIBOX1</example>
        public string BranchId { get; set; }

        /// <summary>
        /// Cash on delivery value. Sets the total value for the entire shipment and only for the first item. The currency of the cash on delivery is automatically set according to the recipient's country. 
        /// Cash on delivery is supported only for countries CZ, SK, HU, SI, HR, RO.
        /// </summary>
        /// <example>1000.0</example>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Variable symbol of the cash on delivery
        /// </summary>
        /// <example>0123456789</example>
        public string Vs { get; set; }

        /// <summary>
        /// Custom naming of the shipment (order number, etc.)
        /// Only numbers (0-9), letters (a-z, A-Z), hyphen (-), slash (/), underscore (_) are allowed
        /// Maximum length of 30 characters
        /// </summary>
        /// <example>1234567890</example>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Package number (for multi-package shipments)
        /// </summary>
        /// <example>1</example>
        public int? PackageNumberOrder { get; set; }

        /// <summary>
        /// Insurance. GLS offers automatic insurance in the amount of 20,000 CZK/package for free. Package insurance (max. 100,000 CZK).
        /// </summary>
        public bool? Insurance { get; set; }

        /// <summary>
        /// Insurance value in CZK. Package insurance (max. 100,000 CZK). Adds the DeclaredValueInsuranceService from the carrier GLS.
        /// </summary>
        /// <example>1000.50</example>
        public decimal? InsurancePrice { get; set; }

        /// <summary>
        /// ExchangeService - GLS picks up another package from the recipient in exchange for the delivered package and delivers it to the sender. In this case, the transport is billed twice.
        /// </summary>
        public bool? ExchangeOrder { get; set; }

        /// <summary>
        /// Shipment collection date in the format YYYY-MM-DD.
        /// </summary>
        /// <example>2024-02-20</example>
        public string PickupDate { get; set; }

        /// <summary>
        /// FlexDeliverySMSService - Includes the FlexDeliveryService with additional notification via SMS.
        /// </summary>
        public bool? SmsNotification { get; set; }

        /// <summary>
        /// FlexDeliveryService - Offers 6 optional solutions for flexible delivery and provides ongoing information to the recipient via email.
        /// </summary>
        public bool? EmailNotification { get; set; }

        /// <summary>
        /// SMSService - SMS notification of the delivery of the shipment on the next working day.
        /// </summary>
        /// <example>false</example>
        [DefaultValue(false)]
        public bool? SmsService { get; set; }

        /// <summary>
        /// SMS text for the SMSService - May contain the following variables: #ParcelNr#,#COD#,#PickupDate#,#From_Name#,#ClientRef#.
        /// </summary>
        /// <example>null</example>
        public string SmsServiceText { get; set; }

        /// <summary>
        /// SMSService - SMS notification of the delivery of the shipment within an estimated 3-hour time interval. 
        /// </summary>
        /// <example>false</example>
        [DefaultValue(false)]
        public bool? SmsPreAdvice { get; set; }

        /// <summary>
        /// Additional service codes. The list of supported service codes can be found in the documentation at https://docs.balikuj.cz
        /// </summary>
        /// <example>["ThinkGreenService"]</example>
        [DefaultValue(null)]
        public List<string> Services { get; set; }
    }
}
