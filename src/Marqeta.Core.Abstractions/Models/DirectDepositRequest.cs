using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DirectDepositRequest
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Token { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DirectDepositRequestType Type { get; set; }

        [JsonProperty("account_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_number { get; set; }

        [JsonProperty("settlement_date", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Settlement_date { get; set; }

        [JsonProperty("standard_entry_class_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(3)]
        public string Standard_entry_class_code { get; set; }

        [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(16)]
        public string Company_name { get; set; }

        [JsonProperty("company_discretionary_data", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string Company_discretionary_data { get; set; }

        [JsonProperty("company_identification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(10)]
        public string Company_identification { get; set; }

        [JsonProperty("company_entry_description", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(10)]
        public string Company_entry_description { get; set; }

        [JsonProperty("individual_identification_number", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(15)]
        public string Individual_identification_number { get; set; }

        [JsonProperty("individual_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(22)]
        public string Individual_name { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}