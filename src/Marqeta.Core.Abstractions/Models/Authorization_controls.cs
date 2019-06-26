using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Authorization_controls
    {
        [JsonProperty("hold_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Hold_increase Hold_increase { get; set; }

        [JsonProperty("hold_expiration_days", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Hold_expiration_days { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}