using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Avs_control_options
    {
        [JsonProperty("validate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Validate { get; set; } = true;

        [JsonProperty("decline_on_address_number_mismatch", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Decline_on_address_number_mismatch { get; set; } = false;

        [JsonProperty("decline_on_postal_code_mismatch", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Decline_on_postal_code_mismatch { get; set; } = true;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}