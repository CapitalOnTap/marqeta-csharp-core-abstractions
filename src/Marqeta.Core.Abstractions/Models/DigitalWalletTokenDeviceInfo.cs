namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DigitalWalletTokenDeviceInfo 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digitalWalletToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DigitalWalletToken DigitalWalletToken { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deviceLanguageCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceLanguageCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deviceSecureElementId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceSecureElementId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deviceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deviceName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deviceLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceLocation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deviceIPAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceIPAddress { get; set; }
    
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