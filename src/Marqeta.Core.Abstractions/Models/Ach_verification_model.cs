using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Ach_verification_model
    {
        [JsonProperty("verify_amount1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Verify_amount1 { get; set; }

        [JsonProperty("verify_amount2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Verify_amount2 { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}