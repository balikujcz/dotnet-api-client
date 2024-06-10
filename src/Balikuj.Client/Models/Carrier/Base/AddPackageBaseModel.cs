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
        /// ID objednávky, ke které daná zásilka patří
        /// </summary>
        public int? OrderId { get; set; }

        /// <summary>
        /// Kód služby dopravce, která se použije pro danou zásilku
        /// </summary>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string ServiceType { get; set; }

        /// <summary>
        /// Jméno a příjmení příjemce
        /// </summary>
        public string RecName { get; set; }

        /// <summary>
        /// Název firmy příjemce
        /// </summary>
        public string RecCompany { get; set; }

        /// <summary>
        /// Název ulice příjemce
        /// </summary>
        public string RecStreet { get; set; }

        /// <summary>
        /// Název města příjemce
        /// </summary>
        public string RecCity { get; set; }

        /// <summary>
        /// PSČ příjemce
        /// </summary>
        public string RecZip { get; set; }

        /// <summary>
        /// Kód země příjemce ve formátu dle ISO 3166-1 alpha-2.
        /// </summary>
        /// <remarks>
        /// Například CZ pro Českou republiku
        /// </remarks>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string RecCountry { get; set; }

        /// <summary>
        /// Telefon příjemce i s předvolbou ve formátu +AAACCCEEEGGG
        /// </summary>
        public string RecPhone { get; set; }

        /// <summary>
        /// Email příjemce
        /// </summary>
        public string RecEmail { get; set; }




        /// <summary>
        /// Byla zadána krycí adresa?
        /// </summary>
        public bool? CoverEnabled { get; set; } = false;

        /// <summary>
        /// Jméno a příjmení krycí adresy
        /// </summary>
        public string CoverName { get; set; }

        /// <summary>
        /// Název firmy krycí adresy
        /// </summary>
        public string CoverCompany { get; set; }

        /// <summary>
        /// Název ulice krycí adresy
        /// </summary>
        public string CoverStreet { get; set; }

        /// <summary>
        /// Název města krycí adresy
        /// </summary>
        public string CoverCity { get; set; }

        /// <summary>
        /// PSČ krycí adresy
        /// </summary>
        public string CoverZip { get; set; }

        /// <summary>
        /// Kód země krycí adresy ve formátu dle ISO 3166-1 alpha-2.
        /// </summary>
        /// <remarks>
        /// Například CZ pro Českou republiku
        /// </remarks>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string CoverCountry { get; set; }

        /// <summary>
        /// Telefon krycí adresy i s předvolbou ve formátu +AAACCCEEEGGG
        /// </summary>
        public string CoverPhone { get; set; }

        /// <summary>
        /// Email krycí adresy
        /// </summary>
        public string CoverEmail { get; set; }


        /// <summary>
        /// Byla zadána adresa odesílatele?
        /// </summary>
        public bool? SenderEnabled { get; set; } = false;

        /// <summary>
        /// Jméno a příjmení adresy odesílatele
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// Název firmy adresy odesílatele
        /// </summary>
        public string SenderCompany { get; set; }

        /// <summary>
        /// Název ulice adresy odesílatele
        /// </summary>
        public string SenderStreet { get; set; }

        /// <summary>
        /// Název města adresy odesílatele
        /// </summary>
        public string SenderCity { get; set; }

        /// <summary>
        /// PSČ adresy odesílatele
        /// </summary>
        public string SenderZip { get; set; }

        /// <summary>
        /// Kód země adresy odesílatele ve formátu dle ISO 3166-1 alpha-2.
        /// </summary>
        /// <remarks>
        /// Například CZ pro Českou republiku
        /// </remarks>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string SenderCountry { get; set; }

        /// <summary>
        /// Telefon adresy odesílatele i s předvolbou ve formátu +AAACCCEEEGGG
        /// </summary>
        public string SenderPhone { get; set; }

        /// <summary>
        /// Email adresy odesílatele
        /// </summary>
        public string SenderEmail { get; set; }
    }
}
