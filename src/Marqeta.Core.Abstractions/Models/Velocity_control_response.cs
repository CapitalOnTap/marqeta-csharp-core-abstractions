using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Velocity_control_response
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Name { get; set; }

        [JsonProperty("association", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Spend_control_association Association { get; set; }

        [JsonProperty("merchant_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Merchant_scope Merchant_scope { get; set; }

        [JsonProperty("usage_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(-1, int.MaxValue)]
        public int? Usage_limit { get; set; }

        /// <summary>Default = true</summary>
        [JsonProperty("approvals_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approvals_only { get; set; } = false;

        /// <summary>Default = true</summary>
        [JsonProperty("include_purchases", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_purchases { get; set; } = false;

        /// <summary>Default = true</summary>
        [JsonProperty("include_withdrawals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_withdrawals { get; set; } = false;

        /// <summary>Default = true</summary>
        [JsonProperty("include_transfers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_transfers { get; set; } = false;

        /// <summary>Default = true</summary>
        [JsonProperty("include_cashback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_cashback { get; set; } = false;

        [JsonProperty("currency_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }

        [JsonProperty("amount_limit", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Amount_limit { get; set; }

        [JsonProperty("velocity_window", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Velocity_control_responseVelocity_window Velocity_window { get; set; }

        /// <summary>Default = true</summary>
        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}