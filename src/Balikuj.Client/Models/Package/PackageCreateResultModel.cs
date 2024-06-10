using Balikuj.Client.Results;
using System.Collections.Generic;

namespace Balikuj.Client.Models.Package
{
    public class PackageCreateResultModel<T> : ApiBaseResult
    {
        public IEnumerable<T> Result { get; set; }

        /// <summary>
        /// Odkaz na stažení štítků ze zvolených zásilek
        /// </summary>
        public string LabelsUrl { get; set; }

        /// <summary>
        /// Hash pro tisk štítků
        /// </summary>
        public string LabelsHash { get; set; }

        /// <summary>
        /// Odkaz na stažení objednávek v PDF, pokud byly u zásilek vyplněny ID objednávek
        /// </summary>
        public string OrdersUrl { get; set; }

        /// <summary>
        /// Hash pro tisk objednávek
        /// </summary>
        public string OrdersHash { get; set; }

        /// <summary>
        /// Počet úspěšně vytvořených zásilek
        /// </summary>
        public int PackagesCount { get; set; }
    }

}
