using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Gatewaylog
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("traceNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TraceNumber { get; set; }

        [JsonProperty("paymentTypeCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentTypeCode { get; set; }

        [JsonProperty("achTransactionType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AchTransactionType { get; set; }

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        [JsonProperty("gatewayVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayVersion { get; set; }

        [JsonProperty("gatewayResponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object GatewayResponse { get; set; }

        [JsonProperty("timedOut", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TimedOut { get; set; } = false;

        [JsonProperty("deal_Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Deal_Id { get; set; }

        [JsonProperty("order_Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Order_Id { get; set; }

        [JsonProperty("request_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Request_method { get; set; }

        [JsonProperty("response_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Response_code { get; set; }

        [JsonProperty("response_subcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Response_subcode { get; set; }

        [JsonProperty("response_reasoncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Response_reasoncode { get; set; }

        [JsonProperty("response_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Response_message { get; set; }

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("fraud_avs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fraud_avs { get; set; }

        [JsonProperty("fraud_auth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fraud_auth { get; set; }

        [JsonProperty("fraud_cvv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fraud_cvv { get; set; }

        [JsonProperty("gateway_transactionId", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Gateway_transactionId { get; set; }

        [JsonProperty("original_gateway", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gatewaylog Original_gateway { get; set; }

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("duplicate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Duplicate { get; set; }

        [JsonProperty("post_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Post_date { get; set; }

        [JsonProperty("response_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Response_time { get; set; }

        [JsonProperty("api_duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Api_duration { get; set; }

        [JsonProperty("gateway_duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Gateway_duration { get; set; }

        [JsonProperty("ach_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ach_status { get; set; }

        [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created { get; set; }

        [JsonProperty("modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Modified { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}