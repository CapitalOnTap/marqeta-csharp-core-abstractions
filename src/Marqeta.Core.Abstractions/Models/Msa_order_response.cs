using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Msa_order_response
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Business_token { get; set; }

        [JsonProperty("order_balances", Required = Required.Always)]
        [Required]
        public Msa_balances Order_balances { get; set; } = new Msa_balances();

        [JsonProperty("purchase_amount", Required = Required.Always)]
        public double Purchase_amount { get; set; }

        [JsonProperty("last_transaction_date", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_transaction_date { get; set; }

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; }

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; }

        [JsonProperty("currency_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }

        [JsonProperty("active", Required = Required.Always)]
        public bool Active { get; set; }

        [JsonProperty("reward_amount", Required = Required.Always)]
        public double Reward_amount { get; set; }

        [JsonProperty("reward_trigger_amount", Required = Required.Always)]
        public double Reward_trigger_amount { get; set; }

        [JsonProperty("unloaded_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unloaded_amount { get; set; }

        [JsonProperty("campaign_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Campaign_token { get; set; }

        [JsonProperty("funding", Required = Required.Always)]
        [Required]
        public Funding Funding { get; set; } = new Funding();

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("aggregated_balances", Required = Required.Always)]
        [Required]
        public Msa_aggregated_balances Aggregated_balances { get; set; } = new Msa_aggregated_balances();

        [JsonProperty("transaction_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Transaction_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}