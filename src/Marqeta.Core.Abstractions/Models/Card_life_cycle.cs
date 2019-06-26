using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_life_cycle
    {
        [JsonProperty("activate_upon_issue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Activate_upon_issue { get; set; } = false;

        [JsonProperty("expiration_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Expiration_offset Expiration_offset { get; set; }

        [JsonProperty("card_service_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Card_service_code { get; set; } = 101;

        [JsonProperty("update_expiration_upon_activation", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_expiration_upon_activation { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}