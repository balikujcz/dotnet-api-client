using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierManipulationUnit
    {
        public int Id { get; set; }

        /// <summary>
        /// Code of the manipulation unit
        /// </summary>
        /// <example>EU</example>
        public string Code { get; set; }

        /// <summary>
        /// Name of the manipulation unit
        /// </summary>
        /// <example>Europaleta</example>
        public string Description { get; set; }

        /// <summary>
        /// Informations if the manipulation unit is returnable
        /// </summary>
        /// <example>false</example>
        public bool Returnable { get; set; }
    }
}
