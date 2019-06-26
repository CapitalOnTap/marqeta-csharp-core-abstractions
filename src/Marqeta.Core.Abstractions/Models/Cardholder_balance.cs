namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Cardholder_balance 
    {
        [Newtonsoft.Json.JsonProperty("currency_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ledger_balance", Required = Newtonsoft.Json.Required.Always)]
        public double Ledger_balance { get; set; }
    
        [Newtonsoft.Json.JsonProperty("available_balance", Required = Newtonsoft.Json.Required.Always)]
        public double Available_balance { get; set; }
    
        [Newtonsoft.Json.JsonProperty("credit_balance", Required = Newtonsoft.Json.Required.Always)]
        public double Credit_balance { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pending_credits", Required = Newtonsoft.Json.Required.Always)]
        public double Pending_credits { get; set; }
    
        [Newtonsoft.Json.JsonProperty("impacted_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Impacted_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("balances", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.IDictionary<string, Cardholder_balance> Balances { get; set; } = new System.Collections.Generic.Dictionary<string, Cardholder_balance>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}