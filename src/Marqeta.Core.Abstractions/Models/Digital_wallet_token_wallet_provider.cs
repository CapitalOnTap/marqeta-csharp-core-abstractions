namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Digital_wallet_token_wallet_provider 
    {
        [Newtonsoft.Json.JsonProperty("wallet_provider_cardholder_wallet_account_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string Wallet_provider_cardholder_wallet_account_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("wallet_provider_risk_assessment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Digital_wallet_token_wallet_providerWallet_provider_risk_assessment? Wallet_provider_risk_assessment { get; set; }
    
        [Newtonsoft.Json.JsonProperty("wallet_provider_risk_assessment_version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string Wallet_provider_risk_assessment_version { get; set; }
    
        [Newtonsoft.Json.JsonProperty("wallet_provider_device_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string Wallet_provider_device_score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("wallet_provider_account_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string Wallet_provider_account_score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("wallet_provider_pan_source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Digital_wallet_token_wallet_providerWallet_provider_pan_source? Wallet_provider_pan_source { get; set; }
    
        [Newtonsoft.Json.JsonProperty("wallet_provider_reason_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Wallet_provider_reason_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("recommendation_reasons", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Recommendation_reasons { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_wallet_account_email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cardholder_wallet_account_email { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}