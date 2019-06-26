using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Avs_controls
    {
        [JsonProperty("av_messages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Avs_control_options Av_messages { get; set; }

        [JsonProperty("auth_messages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Avs_control_options Auth_messages { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}