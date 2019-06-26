using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class RealTimeFeeAssessmentRequest
    {
        [JsonProperty("transaction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RealTimeFeeAssessmentRequestTransaction_type? Transaction_type { get; set; }

        [JsonProperty("international_enabled", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? International_enabled { get; set; } = false;

        [JsonProperty("domestic_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domestic_enabled { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}