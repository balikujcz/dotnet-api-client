using Balikuj.Client.Errors;
using System.Collections.Generic;

namespace Balikuj.Client.Models.Package
{
    public class PackageCreateModel
    {
        /// <summary>
        /// ID záznamu v systému
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// Číslo zásilky dopravce
        /// </summary>
        public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Vlastní pojmenování zásilky (číslo objednávky apod)
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Pořadí balíku zásilce. Pokud zásilka obsahuje více unikátních balíků, určuje pořadí balíku v zásilce
        /// </summary>
        public int? PieceIndex { get; set; }

        /// <summary>
        /// ID objednávky, ke které zásilka patří. Pokud zásilka nepatří k objednávce, vrací se null
        /// </summary>
        public int? OrderId { get; set; }

        public int? OrderNumber { get; set; }

        /// <summary>
        /// Odkaz na stažení štítku pro danou zásilku
        /// </summary>
        public string LabelUrl { get; set; }

        /// <summary>
        /// Odkaz na sledování zásilky
        /// </summary>
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Stavový kód dané zásilky
        /// </summary>
        public int StatusCode { get; set; } = 200;

        /// <summary>
        /// Stavové hlášení k dané zásilce
        /// </summary>
        public string Message { get; set; } = "OK";

        /// <summary>
        /// Seznam případných chybových hlášení z API dopravce. Rozčleněných dle entity, na které se chyba vztahuje, stavového kódu a textu chybového hlášení
        /// </summary>
        public IList<ApiCarrierError> CarrierErrors { get; set; }
    }
}
