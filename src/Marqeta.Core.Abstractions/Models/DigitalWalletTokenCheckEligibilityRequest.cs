using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DigitalWalletTokenCheckEligibilityRequest
    {
        [JsonProperty("pan_source", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DigitalWalletTokenCheckEligibilityRequestPan_source Pan_source { get; set; }

        [JsonProperty("digital_wallet_token_card_data", Required = Required.Always)]
        [Required]
        public Digital_wallet_token_card_info Digital_wallet_token_card_data { get; set; } =
            new Digital_wallet_token_card_info();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}