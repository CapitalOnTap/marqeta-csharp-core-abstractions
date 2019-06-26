namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Transaction_options 
    {
        [Newtonsoft.Json.JsonProperty("additional_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Additional_data { get; set; }
    
        [Newtonsoft.Json.JsonProperty("database_transaction_timeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Database_transaction_timeout { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pre_auth_time_limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pre_auth_time_limit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("send_expiration_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Send_expiration_date { get; set; } = true;
    
        [Newtonsoft.Json.JsonProperty("send_track_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Send_track_data { get; set; } = true;
    
        [Newtonsoft.Json.JsonProperty("card_expiration_date_yymm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Card_expiration_date_yymm { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}