using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Advanced_auth_other_poi
    {
        [JsonProperty("card_presence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Card_presence { get; set; } = false;

        [JsonProperty("cardholder_presence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cardholder_presence { get; set; } = false;

        [JsonProperty("partial_approval_capable", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partial_approval_capable { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}