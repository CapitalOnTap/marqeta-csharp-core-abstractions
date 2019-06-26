﻿namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Withdrawal_request_model 
    {
        [Newtonsoft.Json.JsonProperty("account_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Withdrawal_request_modelAccount_type? Account_type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Card_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(15, MinimumLength = 1)]
        public string Pin { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Mid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_acceptor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_acceptor_model Card_acceptor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}