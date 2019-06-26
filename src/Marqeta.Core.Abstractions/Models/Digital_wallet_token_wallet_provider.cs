using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token_wallet_provider
    {
        [JsonProperty("wallet_provider_cardholder_wallet_account_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(100)]
        public string Wallet_provider_cardholder_wallet_account_id { get; set; }

        [JsonProperty("wallet_provider_risk_assessment", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_token_wallet_providerWallet_provider_risk_assessment? Wallet_provider_risk_assessment
        {
            get;
            set;
        }

        [JsonProperty("wallet_provider_risk_assessment_version", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(10)]
        public string Wallet_provider_risk_assessment_version { get; set; }

        [JsonProperty("wallet_provider_device_score", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(2)]
        public string Wallet_provider_device_score { get; set; }

        [JsonProperty("wallet_provider_account_score", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(2)]
        public string Wallet_provider_account_score { get; set; }

        [JsonProperty("wallet_provider_pan_source", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_token_wallet_providerWallet_provider_pan_source? Wallet_provider_pan_source { get; set; }

        [JsonProperty("wallet_provider_reason_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Wallet_provider_reason_code { get; set; }

        [JsonProperty("recommendation_reasons", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Recommendation_reasons { get; set; }

        [JsonProperty("cardholder_wallet_account_email", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Cardholder_wallet_account_email { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}