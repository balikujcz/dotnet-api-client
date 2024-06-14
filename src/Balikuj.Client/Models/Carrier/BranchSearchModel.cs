using Balikuj.Client.Converters;
using System;
using System.Collections.Generic;
using System.Text;
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
