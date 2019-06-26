using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ReplacementAmount
    {
        [JsonProperty("transaction_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Transaction_amount { get; set; }

        [JsonProperty("settlement_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Settlement_amount { get; set; }

        [JsonProperty("transaction_fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Transaction_fee { get; set; }

        [JsonProperty("settlement_fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Settlement_fee { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}