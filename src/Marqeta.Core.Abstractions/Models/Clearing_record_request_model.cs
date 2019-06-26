namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Clearing_record_request_model 
    {
        [Newtonsoft.Json.JsonProperty("network_fees", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Network_fee_model> Network_fees { get; set; }
    
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Mid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("replacement_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Replacement_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_billing_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cardholder_billing_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_billing_conversion_rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cardholder_billing_conversion_rate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_billing_currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cardholder_billing_currency { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Card_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer_reference_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(23, MinimumLength = 1)]
        public string Acquirer_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16, MinimumLength = 1)]
        public string Rrn { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(12, MinimumLength = 1)]
        public string Stan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("processing_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string Processing_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer_fee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MoneyModel Acquirer_fee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuer_fee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MoneyModel Issuer_fee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("function_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string Function_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reason_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 4)]
        public string Reason_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approval_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 1)]
        public string Approval_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Transaction_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("local_transaction_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Local_transaction_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("settlement_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Settlement_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network_reference_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16, MinimumLength = 1)]
        public string Network_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("find_original_window_days", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Find_original_window_days { get; set; }
    
        [Newtonsoft.Json.JsonProperty("batch_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Batch_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("batch_file_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Batch_file_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sequence_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sequence_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Clearing_record_request_modelNetwork? Network { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sub_network", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Clearing_record_request_modelSub_network? Sub_network { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_acceptor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_acceptor_model Card_acceptor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currency_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        public string Currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("original_data_elements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Original_data_elements Original_data_elements { get; set; }
    
        [Newtonsoft.Json.JsonProperty("preceding_related_transaction_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Preceding_related_transaction_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("send_expiration_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Send_expiration_date { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("simulate_batch_for_clearing_record_hash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Simulate_batch_for_clearing_record_hash { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("cross_border_indicator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Clearing_record_request_modelCross_border_indicator? Cross_border_indicator { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mti", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Clearing_record_request_modelMti? Mti { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}