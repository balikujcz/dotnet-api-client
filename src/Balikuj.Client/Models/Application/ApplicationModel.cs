using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Application
{
    public class ApplicationModel
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
        // Warning: it must be System.Text.Json, because Newtonsoft didn't work and put items into an array
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}
