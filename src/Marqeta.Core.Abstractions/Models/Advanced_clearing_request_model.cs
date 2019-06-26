using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Advanced_clearing_request_model
    {
        [JsonProperty("network_fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Network_fee_model> Network_fees { get; set; }

        [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }

        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50, MinimumLength = 1)]
        public string Mid { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("replacement_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Replacement_amount { get; set; }

        [JsonProperty("cardholder_billing_amount", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Cardholder_billing_amount { get; set; }

        [JsonProperty("cardholder_billing_conversion_rate", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Cardholder_billing_conversion_rate { get; set; }

        [JsonProperty("cardholder_billing_currency", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Cardholder_billing_currency { get; set; }

        [JsonProperty("card_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_token { get; set; }

        [JsonProperty("acquirer_reference_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(23, MinimumLength = 1)]
        public string Acquirer_reference_id { get; set; }

        [JsonProperty("rrn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(16, MinimumLength = 1)]
        public string Rrn { get; set; }

        [JsonProperty("stan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(12, MinimumLength = 1)]
        public string Stan { get; set; }

        [JsonProperty("processing_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(2, MinimumLength = 2)]
        public string Processing_code { get; set; }

        [JsonProperty("acquirer_fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MoneyModel Acquirer_fee { get; set; }

        [JsonProperty("issuer_fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MoneyModel Issuer_fee { get; set; }

        [JsonProperty("function_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(3, MinimumLength = 3)]
        public string Function_code { get; set; }

        [JsonProperty("reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(4, MinimumLength = 4)]
        public string Reason_code { get; set; }

        [JsonProperty("approval_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(6, MinimumLength = 1)]
        public string Approval_code { get; set; }

        [JsonProperty("transaction_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Transaction_date { get; set; }

        [JsonProperty("local_transaction_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Local_transaction_date { get; set; }

        [JsonProperty("settlement_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Settlement_date { get; set; }

        [JsonProperty("network_reference_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(16, MinimumLength = 1)]
        public string Network_reference_id { get; set; }

        [JsonProperty("find_original_window_days", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Find_original_window_days { get; set; }

        [JsonProperty("batch_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Batch_number { get; set; }

        [JsonProperty("batch_file_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Batch_file_name { get; set; }

        [JsonProperty("sequence_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence_number { get; set; }

        [JsonProperty("network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Advanced_clearing_request_modelNetwork? Network { get; set; }

        [JsonProperty("sub_network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Advanced_clearing_request_modelSub_network? Sub_network { get; set; }

        [JsonProperty("card_acceptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_acceptor_model Card_acceptor { get; set; }

        [JsonProperty("currency_code", Required = Required.Always)]
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string Currency_code { get; set; }

        [JsonProperty("original_data_elements", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Original_data_elements Original_data_elements { get; set; }

        [JsonProperty("preceding_related_transaction_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Preceding_related_transaction_token { get; set; }

        [JsonProperty("send_expiration_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_expiration_date { get; set; } = false;

        [JsonProperty("simulate_batch_for_clearing_record_hash", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Simulate_batch_for_clearing_record_hash { get; set; } = false;

        [JsonProperty("cross_border_indicator", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Advanced_clearing_request_modelCross_border_indicator? Cross_border_indicator { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}