namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Transaction_model 
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Transaction_modelType Type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Transaction_modelState State { get; set; }
    
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Identifier { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string User_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("business_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string Business_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acting_user_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string Acting_user_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string Card_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Duration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("created_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Created_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user_transaction_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? User_transaction_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("settlement_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Settlement_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("request_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Request_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cash_back_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cash_back_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currency_conversion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Currency_conversion Currency_conversion { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerInterchangeAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IssuerInterchangeAmount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approval_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Approval_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("response", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Response Response { get; set; }
    
        [Newtonsoft.Json.JsonProperty("preceding_related_transaction_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Preceding_related_transaction_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("incremental_authorization_transaction_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Incremental_authorization_transaction_tokens { get; set; }
    
        [Newtonsoft.Json.JsonProperty("merchant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Merchant_response_model Merchant { get; set; }
    
        [Newtonsoft.Json.JsonProperty("store", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Store_response_model Store { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_acceptor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transaction_card_acceptor Card_acceptor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("gpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Cardholder_balance Gpa { get; set; }
    
        [Newtonsoft.Json.JsonProperty("gpa_order_unload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Gpa_returns Gpa_order_unload { get; set; }
    
        [Newtonsoft.Json.JsonProperty("gpa_order", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Gpa_response Gpa_order { get; set; }
    
        [Newtonsoft.Json.JsonProperty("program_transfer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Program_transfer_response Program_transfer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fee_transfer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Fee_transfer_response Fee_transfer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("peer_transfer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Peer_transfer_response Peer_transfer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("msa_orders", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Msa_order_response> Msa_orders { get; set; }
    
        [Newtonsoft.Json.JsonProperty("msa_order_unload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Msa_returns Msa_order_unload { get; set; }
    
        [Newtonsoft.Json.JsonProperty("offer_orders", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Offer_order_response> Offer_orders { get; set; }
    
        [Newtonsoft.Json.JsonProperty("auto_reload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Auto_reload_model Auto_reload { get; set; }
    
        [Newtonsoft.Json.JsonProperty("direct_deposit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DepositDepositResponse Direct_deposit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("polarity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Transaction_modelPolarity? Polarity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("real_time_fee_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Real_time_fee_group Real_time_fee_group { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Fee Fee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("chargeback", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Chargeback_response Chargeback { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Network { get; set; }
    
        [Newtonsoft.Json.JsonProperty("subnetwork", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subnetwork { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer_fee_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Acquirer_fee_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Network_fee_model> Fees { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digital_wallet_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Digital_wallet_token Digital_wallet_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Cardholder_metadata User { get; set; }
    
        [Newtonsoft.Json.JsonProperty("business", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Business_metadata Business { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_metadata Card { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Acquirer Acquirer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fraud", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Fraud Fraud { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pos Pos { get; set; }
    
        [Newtonsoft.Json.JsonProperty("address_verification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address_verification_model Address_verification { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_security_code_verification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_security_code_verification Card_security_code_verification { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transaction_metadata Transaction_metadata { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card_holder_model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public User_card_holder_response Card_holder_model { get; set; }
    
        [Newtonsoft.Json.JsonProperty("standin_approved_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Standin_approved_by { get; set; }
    
        [Newtonsoft.Json.JsonProperty("standin_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Standin_by { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network_reference_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Network_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer_reference_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Acquirer_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardholder_authentication_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Cardholder_authentication_data Cardholder_authentication_data { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Transaction_attributes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerReceivedTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IssuerReceivedTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerPaymentNode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IssuerPaymentNode { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}