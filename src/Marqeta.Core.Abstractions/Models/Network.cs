using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Network
    {
        [JsonProperty("original_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Original_amount { get; set; }

        [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Conversion_rate { get; set; }

        [JsonProperty("original_currency_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Original_currency_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}