using Balikuj.Client.Converters;
using Balikuj.Client.Models.Carrier.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier.Packeta
{
    public class AddPackagePacketaModel : AddPackageBaseModel, IAddPackageModel
    {

        /// <summary>
        /// Total weight of the package in kg
        /// </summary>
        /// <example>2.5</example>
        public decimal Weight { get; set; }


        // Length of the package in cm (required only for some carriers)
        public decimal? Length { get; set; }

        // Width of the package in cm (required only for some carriers)
        public decimal? Width { get; set; }

        // Height of the package in cm (required only for some carriers)
        public decimal? Height { get; set; }

        /// <summary>
        /// Note for the carrier (maximum length of 128 characters). It will be shortened if the service requires it.
        /// </summary>
        /// <example>Note</example>
        public string Note { get; set; }

        /// <summary>
        /// Declared value of the package
        /// </summary>
        /// <example>1000</example>
        public decimal Price { get; set; }

        /// <summary>
        /// ID of the branch.
        /// </summary>
        public string BranchId { get; set; }

        /// <summary>
        /// Cash on delivery value. Can be a decimal number.
        /// </summary>
        /// <example>1213</example>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Currency of the package value + cash on delivery in ISO 4217 format (CZK)
        /// </summary>
        /// <example>CZK</example>
        public string CodCurrency { get; set; }

        /// <summary>
        /// Sender's name - mandatory if multiple senders are used
        /// If the specified Sender does not exist, a new one will be created
        /// Packeta administration - User information -> Senders
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Age verification of the recipient. If selected, the package will only be handed over to persons over 18 years old.
        /// </summary>
        public bool? AgeCheck { get; set; }

        /// <summary>
        /// Additional service codes. List of supported service codes can be found in the documentation at https://docs.balikuj.cz
        /// </summary>
        /// <example>["1", "3"]</example>
        [JsonConverter(typeof(UpperCaseListStringJsonConverter))]
        public List<string> Services { get; set; }

        /// <summary>
        /// Custom name of the package (order number, etc.)
        /// Only numbers (0-9), letters (a-z, A-Z), hyphen (-), slash (/), underscore (_) are allowed
        /// Maximum length of 30 characters
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Planned pickup
        /// Here you can schedule the pickup of a package that will be delivered to the branch in the usual way, but will not be released before the specified date.
        /// The recipient will also not receive a notification of the possibility of pickup before the specified date (if the package is prepared in advance at the branch, we will notify them at 07:00 on the specified day).
        /// </summary>
        public string ScheduledPickupDate { get; set; }

    }
}
