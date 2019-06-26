namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Card_response 
    {
        [Newtonsoft.Json.JsonProperty("created_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Created_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("last_modified_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Last_modified_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string User_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_product_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Card_product_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("last_four", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Card_responseLast_four Last_four { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pan", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Pan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expiration", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Expiration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expiration_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Expiration_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cvv_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cvv_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("chip_cvv_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Chip_cvv_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("barcode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Barcode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pin_is_set", Required = Newtonsoft.Json.Required.Always)]
        public bool Pin_is_set { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Card_responseState State { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state_reason", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string State_reason { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fulfillment_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Card_responseFulfillment_status Fulfillment_status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reissue_pan_from_card_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reissue_pan_from_card_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fulfillment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CardFulfillmentResponse Fulfillment { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bulk_issuance_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bulk_issuance_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("translate_pin_from_card_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Translate_pin_from_card_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("activation_actions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Activation_actions Activation_actions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("instrument_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Card_responseInstrument_type? Instrument_type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expedite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}