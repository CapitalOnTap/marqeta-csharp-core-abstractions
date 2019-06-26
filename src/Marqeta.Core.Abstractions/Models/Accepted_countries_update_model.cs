using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Accepted_countries_update_model
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("is_whitelist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_whitelist { get; set; } = false;

        [JsonProperty("country_codes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Country_codes { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}