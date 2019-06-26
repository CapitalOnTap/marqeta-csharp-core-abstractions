using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DirectDepositTransitionRequest
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("channel", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DirectDepositTransitionRequestChannel Channel { get; set; }

        [JsonProperty("reason", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Reason { get; set; }

        [JsonProperty("idempotentHash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdempotentHash { get; set; }

        [JsonProperty("direct_deposit_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Direct_deposit_token { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DirectDepositTransitionRequestState State { get; set; }

        [JsonProperty("reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DirectDepositTransitionRequestReason_code? Reason_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}