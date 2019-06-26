namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Transaction_controls 
    {
        [Newtonsoft.Json.JsonProperty("accepted_countries_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Accepted_countries_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("always_require_pin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Always_require_pin { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("always_require_icc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Always_require_icc { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("allow_gpa_auth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_gpa_auth { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("require_card_not_present_card_security_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Require_card_not_present_card_security_code { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("allow_mcc_group_authorization_controls", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_mcc_group_authorization_controls { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("allow_first_pin_set_via_financial_transaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_first_pin_set_via_financial_transaction { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("ignore_card_suspended_state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Ignore_card_suspended_state { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("allow_chip_fallback", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_chip_fallback { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("allow_network_load", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_network_load { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("allow_network_load_card_activation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_network_load_card_activation { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("allow_quasi_cash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Allow_quasi_cash { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("enable_partial_auth_approval", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enable_partial_auth_approval { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("address_verification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Avs_controls Address_verification { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}