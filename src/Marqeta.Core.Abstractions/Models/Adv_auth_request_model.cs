using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Adv_auth_request_model
    {
        [JsonProperty("mti", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Adv_auth_request_modelMti? Mti { get; set; }

        [JsonProperty("network", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Adv_auth_request_modelNetwork Network { get; set; }

        [JsonProperty("sub_network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Adv_auth_request_modelSub_network? Sub_network { get; set; }

        [JsonProperty("is_router_simulator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_router_simulator { get; set; } = false;

        [JsonProperty("network_reference_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Network_reference_id { get; set; }

        [JsonProperty("local_transaction_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Local_transaction_date { get; set; }

        [JsonProperty("transaction_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Transaction_date { get; set; }

        [JsonProperty("settlement_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Settlement_date { get; set; }

        [JsonProperty("stan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Stan { get; set; }

        [JsonProperty("rrn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Rrn { get; set; }

        [JsonProperty("processing_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Processing_code { get; set; }

        [JsonProperty("function_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Function_code { get; set; }

        [JsonProperty("reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Reason_code { get; set; }

        [JsonProperty("acquirer_reference_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Acquirer_reference_id { get; set; }

        [JsonProperty("forwarding_institution_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Adv_auth_request_modelForwarding_institution_id? Forwarding_institution_id { get; set; }

        [JsonProperty("local_transaction_amount", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Local_transaction_amount { get; set; }

        [JsonProperty("local_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Local_currency_code { get; set; }

        [JsonProperty("settlement_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Settlement_amount { get; set; }

        [JsonProperty("cardholder_billing_amount", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Cardholder_billing_amount { get; set; }

        [JsonProperty("cardholder_billing_conversion_rate", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Cardholder_billing_conversion_rate { get; set; }

        [JsonProperty("cardholder_billing_currency", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Cardholder_billing_currency { get; set; }

        [JsonProperty("settlement_currency_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Settlement_currency_code { get; set; }

        [JsonProperty("approval_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Approval_code { get; set; }

        [JsonProperty("network_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(2)]
        public string Network_response { get; set; }

        [JsonProperty("stan_padding_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stan_padding_length { get; set; }

        [JsonProperty("card_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Card_token { get; set; }

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("cash_back_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cash_back_amount { get; set; }

        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        [JsonProperty("pin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pin { get; set; }

        [JsonProperty("pos_pan_entry_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Adv_auth_request_modelPos_pan_entry_mode? Pos_pan_entry_mode { get; set; }

        [JsonProperty("acquirer_fee_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Acquirer_fee_amount { get; set; }

        [JsonProperty("stip_reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Stip_reason_code { get; set; }

        [JsonProperty("is_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_recurring { get; set; } = false;

        [JsonProperty("network_fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Network_fee_model> Network_fees { get; set; }

        [JsonProperty("card_acceptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Advanced_auth_card_acceptor_model Card_acceptor { get; set; }

        [JsonProperty("transaction_options", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Transaction_options Transaction_options { get; set; }

        [JsonProperty("original_data_elements", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Original_data_elements Original_data_elements { get; set; }

        [JsonProperty("replacement_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ReplacementAmount Replacement_amount { get; set; }

        [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }

        [JsonProperty("digital_wallet_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Digital_wallet_token Digital_wallet_token { get; set; }

        [JsonProperty("digital_wallet_token_device_info", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Digital_wallet_token_device Digital_wallet_token_device_info { get; set; }

        [JsonProperty("digital_wallet_token_wallet_provider_info", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Digital_wallet_token_wallet_provider Digital_wallet_token_wallet_provider_info { get; set; }

        [JsonProperty("raw_iso_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Raw_iso_fields { get; set; }

        [JsonProperty("cavv_result_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(1)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Adv_auth_request_modelCavv_result_code? Cavv_result_code { get; set; }

        [JsonProperty("issuer_received_time", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer_received_time { get; set; }

        [JsonProperty("card_options", Required = Required.Always)]
        [Required]
        public Card_options Card_options { get; set; } = new Card_options();

        [JsonProperty("poi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Advanced_auth_poi Poi { get; set; }

        [JsonProperty("is_stip_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_stip_approval { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}