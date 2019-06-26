namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DigitalWalletTokenWalletProviderInfo 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digitalWalletToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DigitalWalletToken DigitalWalletToken { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholderWalletAccountId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CardholderWalletAccountId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("walletProviderAccountEmailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WalletProviderAccountEmailAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("walletProviderRiskAssessment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WalletProviderRiskAssessment { get; set; }
    
        [Newtonsoft.Json.JsonProperty("walletProviderRiskAssessmentVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WalletProviderRiskAssessmentVersion { get; set; }
    
        [Newtonsoft.Json.JsonProperty("walletProviderDeviceScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WalletProviderDeviceScore { get; set; }
    
        [Newtonsoft.Json.JsonProperty("walletProvideAccountScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WalletProvideAccountScore { get; set; }
    
        [Newtonsoft.Json.JsonProperty("walletProviderPanSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WalletProviderPanSource { get; set; }
    
        [Newtonsoft.Json.JsonProperty("walletProviderReasonCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WalletProviderReasonCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("recommendationReasonsSet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DigitalWalletTokenWalletProviderRecommendationReasons> RecommendationReasonsSet { get; set; }
    
        [Newtonsoft.Json.JsonProperty("created_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Created_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("last_modified_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Last_modified_time { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}