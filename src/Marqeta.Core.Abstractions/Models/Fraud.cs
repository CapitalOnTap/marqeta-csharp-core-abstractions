using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Fraud
    {
        [JsonProperty("merchant_risk_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merchant_risk_score { get; set; }

        [JsonProperty("merchant_risk_score_reason_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Merchant_risk_score_reason_code { get; set; }

        [JsonProperty("transaction_risk_score", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Transaction_risk_score { get; set; }

        [JsonProperty("transaction_risk_score_reason_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Transaction_risk_score_reason_code { get; set; }

        [JsonProperty("transaction_risk_score_reason_description", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Transaction_risk_score_reason_description { get; set; }

        [JsonProperty("account_risk_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Account_risk_score { get; set; }

        [JsonProperty("account_risk_score_reason_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Account_risk_score_reason_code { get; set; }

        [JsonProperty("issuerFraudModel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Issuer2 IssuerFraudModel { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}