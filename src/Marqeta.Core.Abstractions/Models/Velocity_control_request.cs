namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Velocity_control_request 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("association", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Spend_control_association Association { get; set; }
    
        [Newtonsoft.Json.JsonProperty("merchant_scope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Merchant_scope Merchant_scope { get; set; }
    
        [Newtonsoft.Json.JsonProperty("usage_limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(-1, int.MaxValue)]
        public int? Usage_limit { get; set; }
    
        /// <summary>Default = true</summary>
        [Newtonsoft.Json.JsonProperty("approvals_only", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Approvals_only { get; set; } = false;
    
        /// <summary>Default = true</summary>
        [Newtonsoft.Json.JsonProperty("include_purchases", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_purchases { get; set; } = false;
    
        /// <summary>Default = true</summary>
        [Newtonsoft.Json.JsonProperty("include_withdrawals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_withdrawals { get; set; } = false;
    
        /// <summary>Default = true</summary>
        [Newtonsoft.Json.JsonProperty("include_transfers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_transfers { get; set; } = false;
    
        /// <summary>Default = true</summary>
        [Newtonsoft.Json.JsonProperty("include_cashback", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_cashback { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("currency_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount_limit", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public double Amount_limit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("velocity_window", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Velocity_control_requestVelocity_window Velocity_window { get; set; }
    
        /// <summary>Default = true</summary>
        [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}