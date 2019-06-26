using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class TranlogToken
    {
        [JsonProperty("tranlogId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TranlogId { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("tranLog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLog TranLog { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}