using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierServiceCountryModel
    {

        /// <summary>
        /// Code of the carrier service
        /// </summary>
        /// <example>DR</example>
        public string Code { get; set; }

        /// <summary>
        /// Code of the countries where the carrier delivers for the given service
        /// </summary>
        /// <example>["CZ", "SK"]</example>
        public List<string> Countries { get; set; }
    }
}
