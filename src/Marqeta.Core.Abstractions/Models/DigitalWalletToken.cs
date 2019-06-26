namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DigitalWalletToken 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card Card { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hash { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secureToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<byte[]> SecureToken { get; set; }
    
        [Newtonsoft.Json.JsonProperty("kid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenAssuranceLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TokenAssuranceLevel { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenRequestorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TokenRequestorId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenRequestorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DigitalWalletTokenTokenRequestorName? TokenRequestorName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenReferenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TokenReferenceId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TokenExpirationDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TokenType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DigitalWalletTokenTokenState? TokenState { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fulfillmentStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DigitalWalletTokenFulfillmentStatus? FulfillmentStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenStateReason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TokenStateReason { get; set; }
    
        [Newtonsoft.Json.JsonProperty("panReferenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PanReferenceId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TokenScore { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerEligibilityDecision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IssuerEligibilityDecision { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tokenServiceProviderEligibilityDecision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TokenServiceProviderEligibilityDecision { get; set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfActiveTokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NumberOfActiveTokens { get; set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfInactiveTokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NumberOfInactiveTokens { get; set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfSuspendedTokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NumberOfSuspendedTokens { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerTermsAndCondition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IssuerTermsAndCondition { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerTermsAndConditionDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IssuerTermsAndConditionDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("correlationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CorrelationId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digitalWalletTokenAttributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DigitalWalletTokenAttribute> DigitalWalletTokenAttributes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("superInactive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SuperInactive { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("numberOfActivationAttempts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NumberOfActivationAttempts { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digitalWalletTokenDevice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DigitalWalletTokenDeviceInfo DigitalWalletTokenDevice { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digitalWalletTokenWalletProvider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DigitalWalletTokenWalletProviderInfo DigitalWalletTokenWalletProvider { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digitalWalletTokenAddressVerification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DigitalWalletTokenAddressVerification DigitalWalletTokenAddressVerification { get; set; }
    
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