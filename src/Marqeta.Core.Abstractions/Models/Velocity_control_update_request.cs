using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Velocity_control_update_request
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("association", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Spend_control_association Association { get; set; }

        [JsonProperty("merchant_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Merchant_scope Merchant_scope { get; set; }

        [JsonProperty("usage_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(-1, int.MaxValue)]
        public int? Usage_limit { get; set; }

        [JsonProperty("approvals_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approvals_only { get; set; } = false;

        [JsonProperty("include_purchases", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_purchases { get; set; } = false;

        [JsonProperty("include_withdrawals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_withdrawals { get; set; } = false;

        [JsonProperty("include_transfers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_transfers { get; set; } = false;

        [JsonProperty("include_cashback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_cashback { get; set; } = false;

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency_code { get; set; }

        [JsonProperty("amount_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public double? Amount_limit { get; set; }

        [JsonProperty("velocity_window", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Velocity_control_update_requestVelocity_window? Velocity_window { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}