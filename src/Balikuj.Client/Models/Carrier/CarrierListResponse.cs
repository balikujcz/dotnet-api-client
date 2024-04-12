using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierListResponse
    {
        /// <summary>
		/// Jméno dopravce
		/// </summary>
		/// <example>PPL CZ s.r.o.</example>
		public string Name { get; set; }


        /// <summary>
        /// Kód dopravce - slouží k párování dopravců u zásilek a objednávek
        /// </summary>
        /// <example>PPL</example>
        public string Code { get; set; }


        /// <summary>
        /// Popis dopravce
        /// </summary>
        /// <example>Balíková přeprava PPL CZ s.r.o.</example>
        public string Description { get; set; }


        /// <summary>
        /// Datum aktivace dopravce, pokud již byl aktivován
        /// </summary>
        /// <example>2023-11-30T16:57:35.646646</example>
        public DateTime? Activated { get; set; }


        /// <summary>
        /// Stav dopravce pro aktuálního uživatele
        /// </summary>
        /// <example>Active</example>
        [DefaultValue(CustomerCarrierActivationStatus.Inactive)]
        public CustomerCarrierActivationStatus Status { get; set; }
    }
}
