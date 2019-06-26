namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Digital_wallet_token_create_request 
    {
        [Newtonsoft.Json.JsonProperty("network", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Digital_wallet_token_create_requestNetwork Network { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_card_info", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Digital_wallet_token_card_info Digital_wallet_token_card_info { get; set; } = new Digital_wallet_token_card_info();
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Digital_wallet_token Digital_wallet_token { get; set; } = new Digital_wallet_token();
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_device", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Digital_wallet_token_device Digital_wallet_token_device { get; set; } = new Digital_wallet_token_device();
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_wallet_provider", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Digital_wallet_token_wallet_provider Digital_wallet_token_wallet_provider { get; set; } = new Digital_wallet_token_wallet_provider();
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_request_address", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Digital_wallet_token_request_address Digital_wallet_token_request_address { get; set; } = new Digital_wallet_token_request_address();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}