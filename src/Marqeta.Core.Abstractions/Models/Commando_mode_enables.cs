using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Commando_mode_enables
    {
        [JsonProperty("program_funding_source", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Program_funding_source { get; set; }

        [JsonProperty("velocity_controls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Velocity_controls { get; set; }

        [JsonProperty("auth_controls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Auth_controls { get; set; }

        [JsonProperty("ignore_card_suspended_state", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_card_suspended_state { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}