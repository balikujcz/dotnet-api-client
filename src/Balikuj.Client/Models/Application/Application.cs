using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Application
{
    public class Application
    {
        public ApplicationTypeModel Type { get; set; }

        /// <summary>
        /// Domain, under which the application runs
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Owner description of the connection (note)
        /// </summary>
        public string Note { get; set; }

        public DateTime? Activated { get; set; }

        public ApplicationStatus Status { get; set; }

        [JsonExtensionData]
        // Watchout, it must be System.Text.Json, because Newtonsoft didn't work and put items into array
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}
