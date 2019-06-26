using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Transaction_model
    {
        [JsonProperty("type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Transaction_modelType Type { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Transaction_modelState State { get; set; }

        [JsonProperty("identifier", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Identifier { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Business_token { get; set; }

        [JsonProperty("acting_user_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(36)]
        public string Acting_user_token { get; set; }

        [JsonProperty("card_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Card_token { get; set; }

        [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("user_transaction_time", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? User_transaction_time { get; set; }

        [JsonProperty("settlement_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Settlement_date { get; set; }

        [JsonProperty("request_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Request_amount { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("cash_back_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cash_back_amount { get; set; }

        [JsonProperty("currency_conversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Currency_conversion Currency_conversion { get; set; }

        [JsonProperty("issuerInterchangeAmount", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? IssuerInterchangeAmount { get; set; }

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency_code { get; set; }

        [JsonProperty("approval_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Approval_code { get; set; }

        [JsonProperty("response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Response Response { get; set; }

        [JsonProperty("preceding_related_transaction_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Preceding_related_transaction_token { get; set; }

        [JsonProperty("incremental_authorization_transaction_tokens", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Incremental_authorization_transaction_tokens { get; set; }

        [JsonProperty("merchant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Merchant_response_model Merchant { get; set; }

        [JsonProperty("store", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Store_response_model Store { get; set; }

        [JsonProperty("card_acceptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Transaction_card_acceptor Card_acceptor { get; set; }

        [JsonProperty("gpa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Cardholder_balance Gpa { get; set; }

        [JsonProperty("gpa_order_unload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gpa_returns Gpa_order_unload { get; set; }

        [JsonProperty("gpa_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gpa_response Gpa_order { get; set; }

        [JsonProperty("program_transfer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Program_transfer_response Program_transfer { get; set; }

        [JsonProperty("fee_transfer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Fee_transfer_response Fee_transfer { get; set; }

        [JsonProperty("peer_transfer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Peer_transfer_response Peer_transfer { get; set; }

        [JsonProperty("msa_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Msa_order_response> Msa_orders { get; set; }

        [JsonProperty("msa_order_unload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Msa_returns Msa_order_unload { get; set; }

        [JsonProperty("offer_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Offer_order_response> Offer_orders { get; set; }

        [JsonProperty("auto_reload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Auto_reload_model Auto_reload { get; set; }

        [JsonProperty("direct_deposit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DepositDepositResponse Direct_deposit { get; set; }

        [JsonProperty("polarity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Transaction_modelPolarity? Polarity { get; set; }

        [JsonProperty("real_time_fee_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Real_time_fee_group Real_time_fee_group { get; set; }

        [JsonProperty("fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Fee Fee { get; set; }

        [JsonProperty("chargeback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Chargeback_response Chargeback { get; set; }

        [JsonProperty("network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Network { get; set; }

        [JsonProperty("subnetwork", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Subnetwork { get; set; }

        [JsonProperty("acquirer_fee_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Acquirer_fee_amount { get; set; }

        [JsonProperty("fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Network_fee_model> Fees { get; set; }

        [JsonProperty("digital_wallet_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Digital_wallet_token Digital_wallet_token { get; set; }

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Cardholder_metadata User { get; set; }

        [JsonProperty("business", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Business_metadata Business { get; set; }

        [JsonProperty("card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_metadata Card { get; set; }

        [JsonProperty("acquirer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Acquirer Acquirer { get; set; }

        [JsonProperty("fraud", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Fraud Fraud { get; set; }

        [JsonProperty("pos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Pos Pos { get; set; }

        [JsonProperty("address_verification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Address_verification_model Address_verification { get; set; }

        [JsonProperty("card_security_code_verification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Card_security_code_verification Card_security_code_verification { get; set; }

        [JsonProperty("transaction_metadata", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Transaction_metadata Transaction_metadata { get; set; }

        [JsonProperty("card_holder_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public User_card_holder_response Card_holder_model { get; set; }

        [JsonProperty("standin_approved_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Standin_approved_by { get; set; }

        [JsonProperty("standin_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Standin_by { get; set; }

        [JsonProperty("network_reference_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Network_reference_id { get; set; }

        [JsonProperty("acquirer_reference_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Acquirer_reference_id { get; set; }

        [JsonProperty("cardholder_authentication_data", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Cardholder_authentication_data Cardholder_authentication_data { get; set; }

        [JsonProperty("transaction_attributes", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Transaction_attributes { get; set; }

        [JsonProperty("issuerReceivedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerReceivedTime { get; set; }

        [JsonProperty("issuerPaymentNode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerPaymentNode { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}