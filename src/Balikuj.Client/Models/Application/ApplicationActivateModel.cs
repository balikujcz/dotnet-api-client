using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Balikuj.Client.Models.Application
{
    public class ApplicationActivateModel
    {
        /// <summary>
        /// Code of the application we want to activate. The list of available applications can be obtained by calling /Application/Types
		/// </summary>
		public string Code { get; set; }

        [JsonExtensionData]
        // Warning must be System.Text.Json, because Newtonsoft did not work and put items into an array
        public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = new Dictionary<string, JsonElement>();
    }
}
