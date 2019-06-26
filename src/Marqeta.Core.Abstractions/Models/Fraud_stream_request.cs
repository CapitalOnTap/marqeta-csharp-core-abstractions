using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Fraud_stream_request
    {
        [JsonProperty("program", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Program { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Fraud_stream_requestType? Type { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Fraud_stream_requestState? State { get; set; }

        [JsonProperty("itc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Itc { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("acting_user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Acting_user_token { get; set; }

        [JsonProperty("card_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Card_token { get; set; }

        [JsonProperty("user_transaction_time", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? User_transaction_time { get; set; }

        [JsonProperty("request_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Request_amount { get; set; }

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency_code { get; set; }

        [JsonProperty("network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Network { get; set; }

        [JsonProperty("account_risk_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Account_risk_score { get; set; }

        [JsonProperty("account_risk_score_reason_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Account_risk_score_reason_code { get; set; }

        [JsonProperty("transaction_risk_score", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Transaction_risk_score { get; set; }

        [JsonProperty("transaction_risk_score_reason_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Transaction_risk_score_reason_code { get; set; }

        [JsonProperty("card_acceptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Transaction_card_acceptor_view_model_v1 Card_acceptor { get; set; }

        [JsonProperty("address_verification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Address_verification_model Address_verification { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}