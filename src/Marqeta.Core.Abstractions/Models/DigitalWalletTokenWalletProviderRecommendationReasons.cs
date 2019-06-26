using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DigitalWalletTokenWalletProviderRecommendationReasons
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("digitalWalletTokenWalletProviderInfo", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletTokenWalletProviderInfo DigitalWalletTokenWalletProviderInfo { get; set; }

        [JsonProperty("reasonCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        [JsonProperty("recommendationReasons", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string RecommendationReasons { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}