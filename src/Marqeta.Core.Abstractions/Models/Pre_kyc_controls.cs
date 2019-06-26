using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Pre_kyc_controls
    {
        [JsonProperty("cash_access_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cash_access_enabled { get; set; } = false;

        [JsonProperty("international_enabled", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? International_enabled { get; set; } = false;

        [JsonProperty("balance_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public double? Balance_max { get; set; }

        [JsonProperty("enable_non_program_loads", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_non_program_loads { get; set; } = false;

        [JsonProperty("is_reloadable_pre_kyc", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_reloadable_pre_kyc { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}