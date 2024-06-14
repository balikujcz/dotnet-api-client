using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierServiceAddonModel
    {

        /// <summary>
        /// Code of the additional service
        /// </summary>
        /// <example>1</example>
        public string Code { get; set; }

        /// <summary>
        /// Short name of the additional service
        /// </summary>
        /// <example>1</example>
        public string ShortName { get; set; }

        /// <summary>
        /// Description of the additional service
        /// </summary>
        /// <example>Do vlastních rukou</example>
        public string Description { get; set; }
    }
}
