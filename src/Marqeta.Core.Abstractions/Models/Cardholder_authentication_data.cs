using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Cardholder_authentication_data
    {
        [JsonProperty("electronic_commerce_indicator", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Electronic_commerce_indicator { get; set; }

        [JsonProperty("verification_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Verification_result { get; set; }

        [JsonProperty("verification_value_created_by", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Verification_value_created_by { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}