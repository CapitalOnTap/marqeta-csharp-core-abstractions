using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Bank_transfer_transition_response_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Token { get; set; }

        [JsonProperty("bank_transfer_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(36)]
        public string Bank_transfer_token { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Bank_transfer_transition_response_modelStatus Status { get; set; }

        [JsonProperty("reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        [JsonProperty("channel", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Bank_transfer_transition_response_modelChannel Channel { get; set; }

        [JsonProperty("batch_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Batch_number { get; set; }

        [JsonProperty("program_reserve_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Program_reserve_token { get; set; }

        [JsonProperty("transaction_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Transaction_token { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}