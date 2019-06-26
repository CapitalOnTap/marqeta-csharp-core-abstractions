using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class AccountHolderGroup
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("realTimeFeeGroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Real_time_fee_group RealTimeFeeGroup { get; set; }

        [JsonProperty("isReloadable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReloadable { get; set; } = false;

        [JsonProperty("cashAccessEnabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CashAccessEnabled { get; set; } = false;

        [JsonProperty("internationalEnabled", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? InternationalEnabled { get; set; } = false;

        [JsonProperty("nonProgramLoadsEnabled", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonProgramLoadsEnabled { get; set; } = false;

        [JsonProperty("isReloadablePreKyc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReloadablePreKyc { get; set; } = false;

        [JsonProperty("kycRequired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KycRequired { get; set; }

        [JsonProperty("balanceMax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BalanceMax { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}