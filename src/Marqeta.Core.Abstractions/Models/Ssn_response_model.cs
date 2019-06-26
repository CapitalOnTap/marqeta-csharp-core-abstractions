using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Ssn_response_model
    {
        [JsonProperty("ssn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ssn { get; set; }

        [JsonProperty("tin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tin { get; set; }

        [JsonProperty("sin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Sin { get; set; }

        [JsonProperty("nin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Nin { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}