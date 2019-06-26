namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BulkCardOrder 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardsOrdered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CardsOrdered { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardsProcessed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CardsProcessed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("singleInventoryUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SingleInventoryUser { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("inventoryCardHolder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserCardHolder InventoryCardHolder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nameLine1NumericPostfix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? NameLine1NumericPostfix { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("nameLine1NumericStartIndex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NameLine1NumericStartIndex { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nameLine1NumericEndIndex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NameLine1NumericEndIndex { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardProduct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_product CardProduct { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shippingMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BulkCardOrderShippingMethod? ShippingMethod { get; set; }
    
        [Newtonsoft.Json.JsonProperty("returnAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FulfillmentAddress ReturnAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("recipientAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FulfillmentAddress RecipientAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("careOfLine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CareOfLine { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardPersonalization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_personalization CardPersonalization { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fileProcessed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FileProcessed { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("fulfillmentTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FulfillmentTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expedite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("expirationOffsetValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ExpirationOffsetValue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expirationOffsetUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BulkCardOrderExpirationOffsetUnit? ExpirationOffsetUnit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("providerShipDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProviderShipDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("providerShippingMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProviderShippingMethod { get; set; }
    
        [Newtonsoft.Json.JsonProperty("providerTrackingNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProviderTrackingNumber { get; set; }
    
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