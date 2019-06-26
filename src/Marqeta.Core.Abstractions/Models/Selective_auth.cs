using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Selective_auth
    {
        [JsonProperty("sa_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sa_mode { get; set; } = 1;

        [JsonProperty("enable_regex_search_chain", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_regex_search_chain { get; set; } = false;

        [JsonProperty("dmd_location_sensitivity", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Dmd_location_sensitivity { get; set; } = 0;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}