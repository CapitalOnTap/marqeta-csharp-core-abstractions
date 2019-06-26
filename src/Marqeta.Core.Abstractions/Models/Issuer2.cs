using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Issuer2
    {
        [JsonProperty("success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; } = false;

        [JsonProperty("fraud_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fraud_score { get; set; }

        [JsonProperty("fraud_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fraud_rating { get; set; }

        [JsonProperty("rule_violations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Rule_violations { get; set; }

        [JsonProperty("fraud_score_reasons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Fraud_score_reasons { get; set; }

        [JsonProperty("recommended_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Recommended_action { get; set; }

        [JsonProperty("model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}