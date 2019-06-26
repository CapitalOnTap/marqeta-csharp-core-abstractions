using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class User_card_holder_search_model
    {
        [JsonProperty("ssn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ssn { get; set; }

        [JsonProperty("dda", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Dda { get; set; }

        [JsonProperty("first_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string First_name { get; set; }

        [JsonProperty("last_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Last_name { get; set; }

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Phone { get; set; }

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
        public string Email { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}