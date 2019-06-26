using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Account_holder_group_config
    {
        [JsonProperty("kyc_required", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Account_holder_group_configKyc_required? Kyc_required { get; set; }

        [JsonProperty("is_reloadable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_reloadable { get; set; } = false;

        [JsonProperty("real_time_fee_group_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Real_time_fee_group_token { get; set; }

        [JsonProperty("pre_kyc_controls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Pre_kyc_controls Pre_kyc_controls { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}