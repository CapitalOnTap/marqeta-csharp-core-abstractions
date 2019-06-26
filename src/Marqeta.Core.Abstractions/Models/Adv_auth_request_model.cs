namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Adv_auth_request_model 
    {
        [Newtonsoft.Json.JsonProperty("mti", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Adv_auth_request_modelMti? Mti { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Adv_auth_request_modelNetwork Network { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sub_network", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Adv_auth_request_modelSub_network? Sub_network { get; set; }
    
        [Newtonsoft.Json.JsonProperty("is_router_simulator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Is_router_simulator { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("network_reference_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Network_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("local_transaction_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Local_transaction_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Transaction_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("settlement_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Settlement_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Stan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Rrn { get; set; }
    
        [Newtonsoft.Json.JsonProperty("processing_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Processing_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("function_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Function_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reason_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer_reference_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Acquirer_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("forwarding_institution_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Adv_auth_request_modelForwarding_institution_id? Forwarding_institution_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("local_transaction_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Local_transaction_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("local_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Local_currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("settlement_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Settlement_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_billing_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cardholder_billing_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_billing_conversion_rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cardholder_billing_conversion_rate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_billing_currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cardholder_billing_currency { get; set; }
    
        [Newtonsoft.Json.JsonProperty("settlement_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Settlement_currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approval_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Approval_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network_response", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string Network_response { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stan_padding_length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Stan_padding_length { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Card_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cash_back_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cash_back_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pin { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pos_pan_entry_mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Adv_auth_request_modelPos_pan_entry_mode? Pos_pan_entry_mode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer_fee_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Acquirer_fee_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stip_reason_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Stip_reason_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("is_recurring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Is_recurring { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("network_fees", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Network_fee_model> Network_fees { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_acceptor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Advanced_auth_card_acceptor_model Card_acceptor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_options", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transaction_options Transaction_options { get; set; }
    
        [Newtonsoft.Json.JsonProperty("original_data_elements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Original_data_elements Original_data_elements { get; set; }
    
        [Newtonsoft.Json.JsonProperty("replacement_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReplacementAmount Replacement_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Digital_wallet_token Digital_wallet_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_device_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Digital_wallet_token_device Digital_wallet_token_device_info { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token_wallet_provider_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Digital_wallet_token_wallet_provider Digital_wallet_token_wallet_provider_info { get; set; }
    
        [Newtonsoft.Json.JsonProperty("raw_iso_fields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Raw_iso_fields { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cavv_result_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Adv_auth_request_modelCavv_result_code? Cavv_result_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuer_received_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Issuer_received_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_options", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Card_options Card_options { get; set; } = new Card_options();
    
        [Newtonsoft.Json.JsonProperty("poi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Advanced_auth_poi Poi { get; set; }
    
        [Newtonsoft.Json.JsonProperty("is_stip_approval", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Is_stip_approval { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}