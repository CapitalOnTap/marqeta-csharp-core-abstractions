namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Transaction_metadata 
    {
        [Newtonsoft.Json.JsonProperty("transaction_category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Transaction_metadataTransaction_category? Transaction_category { get; set; }
    
        [Newtonsoft.Json.JsonProperty("payment_channel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Transaction_metadataPayment_channel? Payment_channel { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cross_border_transaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Cross_border_transaction { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("authorization_life_cyle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Authorization_life_cyle { get; set; }
    
        [Newtonsoft.Json.JsonProperty("is_lodging_auto_rental", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Is_lodging_auto_rental { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("lodging_auto_rental_start_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Lodging_auto_rental_start_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transit Transit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("airline", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Airline Airline { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}