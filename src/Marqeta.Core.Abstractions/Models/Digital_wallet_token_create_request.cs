using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token_create_request
    {
        [JsonProperty("network", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_token_create_requestNetwork Network { get; set; }

        [JsonProperty("digital_wallet_token_card_info", Required = Required.Always)]
        [Required]
        public Digital_wallet_token_card_info Digital_wallet_token_card_info { get; set; } =
            new Digital_wallet_token_card_info();

        [JsonProperty("digital_wallet_token", Required = Required.Always)]
        [Required]
        public Digital_wallet_token Digital_wallet_token { get; set; } = new Digital_wallet_token();

        [JsonProperty("digital_wallet_token_device", Required = Required.Always)]
        [Required]
        public Digital_wallet_token_device Digital_wallet_token_device { get; set; } =
            new Digital_wallet_token_device();

        [JsonProperty("digital_wallet_token_wallet_provider", Required = Required.Always)]
        [Required]
        public Digital_wallet_token_wallet_provider Digital_wallet_token_wallet_provider { get; set; } =
            new Digital_wallet_token_wallet_provider();

        [JsonProperty("digital_wallet_token_request_address", Required = Required.Always)]
        [Required]
        public Digital_wallet_token_request_address Digital_wallet_token_request_address { get; set; } =
            new Digital_wallet_token_request_address();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}