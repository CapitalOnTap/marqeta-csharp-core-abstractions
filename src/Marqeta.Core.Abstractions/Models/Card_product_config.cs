namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Card_product_config 
    {
        [Newtonsoft.Json.JsonProperty("poi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Poi Poi { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_controls", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transaction_controls Transaction_controls { get; set; }
    
        [Newtonsoft.Json.JsonProperty("selective_auth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Selective_auth Selective_auth { get; set; }
    
        [Newtonsoft.Json.JsonProperty("special", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Special Special { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_life_cycle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_life_cycle Card_life_cycle { get; set; }
    
        [Newtonsoft.Json.JsonProperty("clearing_and_settlement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Clearing_and_settlement Clearing_and_settlement { get; set; }
    
        [Newtonsoft.Json.JsonProperty("jit_funding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Jit_funding Jit_funding { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_tokenization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Digital_wallet_tokenization Digital_wallet_tokenization { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fulfillment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_product_fulfillment Fulfillment { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}