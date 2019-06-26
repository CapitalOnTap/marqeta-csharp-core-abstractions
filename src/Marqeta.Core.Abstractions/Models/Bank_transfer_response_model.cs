using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Bank_transfer_response_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Token { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Amount { get; set; }

        [JsonProperty("fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<double> Fees { get; set; }

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        [JsonProperty("funding_source_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(36)]
        public string Funding_source_token { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Bank_transfer_response_modelType? Type { get; set; }

        /// <summary>Default = USD</summary>
        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency_code { get; set; }

        /// <summary>Default = STANDARD</summary>
        [JsonProperty("transfer_speed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Bank_transfer_response_modelTransfer_speed? Transfer_speed { get; set; }

        [JsonProperty("standard_entry_class_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Bank_transfer_response_modelStandard_entry_class_code Standard_entry_class_code { get; set; }

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Bank_transfer_response_modelStatus? Status { get; set; }

        [JsonProperty("transitions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Bank_transfer_transition_response_model> Transitions { get; set; }

        [JsonProperty("batch_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Batch_number { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}