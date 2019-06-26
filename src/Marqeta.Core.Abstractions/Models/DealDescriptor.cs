using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DealDescriptor
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Campaign Campaign { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("purchaseStartDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PurchaseStartDate { get; set; }

        [JsonProperty("purchaseEndDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PurchaseEndDate { get; set; }

        [JsonProperty("purchaseAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PurchaseAmount { get; set; }

        [JsonProperty("rewardAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RewardAmount { get; set; }

        [JsonProperty("rewardTriggerAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RewardTriggerAmount { get; set; }

        [JsonProperty("campaignToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignToken { get; set; }

        [JsonProperty("currencyCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }

        [JsonProperty("idempotentHash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdempotentHash { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonProperty("totalAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAmount { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}