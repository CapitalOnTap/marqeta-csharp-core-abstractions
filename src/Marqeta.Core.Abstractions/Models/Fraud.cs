namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Fraud 
    {
        [Newtonsoft.Json.JsonProperty("merchant_risk_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Merchant_risk_score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("merchant_risk_score_reason_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Merchant_risk_score_reason_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_risk_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Transaction_risk_score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_risk_score_reason_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Transaction_risk_score_reason_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_risk_score_reason_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Transaction_risk_score_reason_description { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account_risk_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Account_risk_score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account_risk_score_reason_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account_risk_score_reason_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerFraudModel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Issuer2 IssuerFraudModel { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}