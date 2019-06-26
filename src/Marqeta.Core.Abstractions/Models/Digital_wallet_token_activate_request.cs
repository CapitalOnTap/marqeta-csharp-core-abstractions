using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token_activate_request
    {
        [JsonProperty("digital_wallet_token", Required = Required.Always)]
        [Required]
        public Digital_wallet_token Digital_wallet_token { get; set; } = new Digital_wallet_token();

        [JsonProperty("digital_wallet_token_device", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Digital_wallet_token_device Digital_wallet_token_device { get; set; }

        [JsonProperty("digital_wallet_token_wallet_provider", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Digital_wallet_token_wallet_provider Digital_wallet_token_wallet_provider { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}