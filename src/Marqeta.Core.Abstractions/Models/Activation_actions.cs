using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Activation_actions
    {
        [JsonProperty("terminate_reissued_source_card", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Terminate_reissued_source_card { get; set; } = true;

        [JsonProperty("swap_digital_wallet_tokens_from_card_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Swap_digital_wallet_tokens_from_card_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}