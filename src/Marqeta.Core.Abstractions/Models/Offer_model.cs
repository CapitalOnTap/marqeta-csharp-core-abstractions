using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Offer_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = true;

        [JsonProperty("name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string Name { get; set; }

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; }

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; }

        [JsonProperty("purchase_amount", Required = Required.Always)]
        public double Purchase_amount { get; set; }

        [JsonProperty("reward_amount", Required = Required.Always)]
        public double Reward_amount { get; set; }

        [JsonProperty("reward_trigger_amount", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Reward_trigger_amount { get; set; }

        [JsonProperty("campaign_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Campaign_token { get; set; }

        [JsonProperty("currency_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}