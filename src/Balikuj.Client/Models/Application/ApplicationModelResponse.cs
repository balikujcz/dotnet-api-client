using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Application
{
    public class ApplicationModelResponse
    {
        public ApplicationTypeModel Type { get; set; }

        /// <summary>
        /// Doména, pod kterou běží aplikace
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Vlastní popis napojení (poznámka)
        /// </summary>
        public string Note { get; set; }

        public DateTime? Activated { get; set; }

        public ApplicationStatus Status { get; set; }

        [JsonExtensionData] // Pozor musí být  System.Text.Json, jelikož Newtonsoft nefungoval a dávál položky do pole
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}
