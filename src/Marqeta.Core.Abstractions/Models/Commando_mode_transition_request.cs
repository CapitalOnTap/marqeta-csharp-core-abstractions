using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Commando_mode_transition_request
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("commando_mode_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Commando_mode_token { get; set; }

        [JsonProperty("transition", Required = Required.Always)]
        [Required]
        public Commando_mode_nested_transition Transition { get; set; } = new Commando_mode_nested_transition();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}