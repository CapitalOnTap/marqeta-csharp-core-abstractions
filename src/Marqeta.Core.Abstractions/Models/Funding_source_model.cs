namespace Marqeta.Core.Abstractions
{
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("payment_card_funding_source_model", typeof(Payment_card_funding_source_model))]
    [JsonInheritance("program_funding_source_model", typeof(Program_funding_source_model))]
    [JsonInheritance("direct_deposit_funding_source_model", typeof(Direct_deposit_funding_source_model))]
    [JsonInheritance("chargeback_funding_source_model", typeof(Chargeback_funding_source_model))]
    [JsonInheritance("bank_account_funding_source_model", typeof(Bank_account_funding_source_model))]
    [JsonInheritance("program_gateway_funding_source_model", typeof(Program_gateway_funding_source_model))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Funding_source_model 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("is_default_account", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_default_account { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("created_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Created_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("last_modified_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Last_modified_time { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}