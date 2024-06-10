using System.Collections.Generic;
using System.Text.Json.Serialization;
using Balikuj.Client.Converters;
using Balikuj.Client.Models.Carrier.Base;

namespace Balikuj.Client.Models.Carrier.Cp
{
    public class AddPackageCpModel : AddPackageBaseModel, IAddPackageModel
    {
        /// <summary>
        /// Referenční číslo/ID zásilky.
        /// </summary>
        /// <example>Reference balíku</example>
        public string Reference { get; set; }

        /// <summary>
        /// Celková váha zásilky v kg
        /// </summary>
        /// <example>1.5</example>
        public decimal Weight { get; set; }

        /// <summary>
        /// Poznámka dopravci (maximální délka 50 znaků). Bude vytištěno na štítku.
        /// </summary>
        /// <example>Prosím, neotvírejte</example>
        public string Note { get; set; }

        /// <summary>
        /// Udávaná hodnota zásilky. Kód služby = 7 se přidává automaticky k zásilce, která to podporuje.
        /// </summary>
        /// <example>1000.50</example>
        public decimal Price { get; set; }

        /// <summary>
        /// ID výdejního místa. Seznam výdejních míst je možné získat přes metodu Branches
        /// </summary>
        /// <example>CZ10037</example>
        public string BranchId { get; set; }

        /// <summary>
        /// Hodnota dobírky. Může být desetinné číslo.
        /// </summary>
        /// <example>1000.50</example>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Měna dobírky v ISO 4217 formátu (CZK). Podporována je zatím pouze "CZK".
        /// </summary>
        /// <example>CZK</example>
        public string CodCurrency { get; set; }

        /// <summary>
        /// Variabilní symbol dobírky, povinný pro dobírkové zásilky
        /// </summary>
        /// <example>1234567890</example>
        public string Vs { get; set; }

        /// <summary>
        /// Šířka v cm - povinná pro typ služby BN
        /// </summary>
        /// <example>20.0</example>
        public decimal? Width { get; set; }

        /// <summary>
        /// Výška v cm - povinná pro typ služby BN
        /// </summary>
        /// <example>30.0</example>
        public decimal? Height { get; set; }

        /// <summary>
        /// Délka v cm - povinná pro typ služby BN
        /// </summary>
        /// <example>55.0</example>
        public decimal? Length { get; set; }

        /// <summary>
        /// Kódy doplňkových služeb. Seznam podporovaných kódu služeb najdete v dokumentaci na https://docs.balikuj.cz
        /// </summary>
        /// <example>["1", "3"]</example>
        [JsonConverter(typeof(UpperCaseListStringJsonConverter))]
        public List<string> Services { get; set; }

        /// <summary>
        /// Velikost zásilky u služeb, které vyžadují velikostní kategorii (S, M, L, XL)
        /// </summary>
        /// <example>S</example>
        [JsonConverter(typeof(UpperCaseStringJsonConverter))]
        public string Size { get; set; }

        /// <summary>
        /// Hodnota připojištění v CZK. Pokud není vyplněna, použije se hodnota Price
        /// </summary>
        /// <example>1000.50</example>
        public decimal? InsurancePrice { get; set; }

        /// <summary>
        /// Měna připojištění, zatím podporována pouze výchozí měna "CZK"
        /// </summary>
        /// <example>CZK</example>
        public string InsuranceCurrency { get; set; }

        /// <summary>
        /// Vlastní pojmenování zásilky (číslo objednávky apod)
        /// Povoleny jsou pouze čísla (0-9), písmena (a-z, A-Z), pomlčka (-), lomítko (/), podtržítko (_)
        /// O maximální délce 30 znaků
        /// </summary>
        /// <example>1234567890</example>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Pořadové číslo balíku (u vícebalíkových zásilek)
        /// </summary>
        /// <example>1</example>
        public int? PackageNumberOrder { get; set; }
    }
}
