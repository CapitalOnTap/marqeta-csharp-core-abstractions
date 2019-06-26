namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CardProductFulfillmentResponse 
    {
        [Newtonsoft.Json.JsonProperty("shipping", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ShippingInformationResponse Shipping { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_personalization", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Card_personalization Card_personalization { get; set; } = new Card_personalization();
    
        [Newtonsoft.Json.JsonProperty("payment_instrument", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardProductFulfillmentResponsePayment_instrument? Payment_instrument { get; set; }
    
        [Newtonsoft.Json.JsonProperty("package_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Package_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("all_zero_card_security_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? All_zero_card_security_code { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("bin_prefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bin_prefix { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bulk_ship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Bulk_ship { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("pan_length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pan_length { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fulfillment_provider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardProductFulfillmentResponseFulfillment_provider? Fulfillment_provider { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allow_card_creation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_card_creation { get; set; } = true;
    
        [Newtonsoft.Json.JsonProperty("uppercase_name_lines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Uppercase_name_lines { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("enable_offline_pin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enable_offline_pin { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}