using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DepositDepositResponse
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DepositDepositResponseType? Type { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DepositDepositResponseState? State { get; set; }

        [JsonProperty("settlement_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Settlement_date { get; set; }

        [JsonProperty("state_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State_reason { get; set; }

        [JsonProperty("state_reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State_reason_code { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Business_token { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonProperty("standard_entry_class_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Standard_entry_class_code { get; set; }

        [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Company_name { get; set; }

        [JsonProperty("company_discretionary_data", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Company_discretionary_data { get; set; }

        [JsonProperty("company_identification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Company_identification { get; set; }

        [JsonProperty("company_entry_description", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Company_entry_description { get; set; }

        [JsonProperty("individual_identification_number", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Individual_identification_number { get; set; }

        [JsonProperty("individual_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Individual_name { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}