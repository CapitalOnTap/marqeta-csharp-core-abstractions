namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Digital_wallet_token_activate_request 
    {
        [Newtonsoft.Json.JsonProperty("digital_wallet_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Digital_wallet_token Digital_wallet_token { get; set; } = new Digital_wallet_token();
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_device", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Digital_wallet_token_device Digital_wallet_token_device { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_wallet_provider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Digital_wallet_token_wallet_provider Digital_wallet_token_wallet_provider { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}