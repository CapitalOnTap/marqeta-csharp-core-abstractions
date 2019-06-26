using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DigitalWalletTokenWalletProviderInfo
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("digitalWalletToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletToken DigitalWalletToken { get; set; }

        [JsonProperty("cardholderWalletAccountId", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string CardholderWalletAccountId { get; set; }

        [JsonProperty("walletProviderAccountEmailAddress", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProviderAccountEmailAddress { get; set; }

        [JsonProperty("walletProviderRiskAssessment", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProviderRiskAssessment { get; set; }

        [JsonProperty("walletProviderRiskAssessmentVersion", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProviderRiskAssessmentVersion { get; set; }

        [JsonProperty("walletProviderDeviceScore", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProviderDeviceScore { get; set; }

        [JsonProperty("walletProvideAccountScore", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProvideAccountScore { get; set; }

        [JsonProperty("walletProviderPanSource", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProviderPanSource { get; set; }

        [JsonProperty("walletProviderReasonCode", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProviderReasonCode { get; set; }

        [JsonProperty("recommendationReasonsSet", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DigitalWalletTokenWalletProviderRecommendationReasons> RecommendationReasonsSet { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}