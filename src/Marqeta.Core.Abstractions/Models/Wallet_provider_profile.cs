using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Wallet_provider_profile
    {
        [JsonProperty("account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Account2 Account { get; set; }

        [JsonProperty("risk_assessment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Risk_assessment Risk_assessment { get; set; }

        [JsonProperty("device_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device_score { get; set; }

        [JsonProperty("pan_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pan_source { get; set; }

        [JsonProperty("reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Reason_code { get; set; }

        [JsonProperty("recommendation_reasons", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Recommendation_reasons { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}