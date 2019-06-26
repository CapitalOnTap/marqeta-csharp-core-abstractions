using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token_transition_request
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_token_transition_requestReason_code? Reason_code { get; set; }

        [JsonProperty("token_reference_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_reference_id { get; set; }

        [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_token_transition_requestChannel? Channel { get; set; }

        [JsonProperty("digital_wallet_token", Required = Required.Always)]
        [Required]
        public Digital_wallet_token_hash Digital_wallet_token { get; set; } = new Digital_wallet_token_hash();

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_token_transition_requestState State { get; set; }

        [JsonProperty("reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Reason { get; set; }

        [JsonProperty("override_tsp_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override_tsp_error { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}