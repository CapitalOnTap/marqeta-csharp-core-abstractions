using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Merchant_scope
    {
        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        [JsonProperty("mcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        [JsonProperty("mcc_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc_group { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}