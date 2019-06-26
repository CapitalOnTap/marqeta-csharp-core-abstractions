using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_personalization
    {
        [JsonProperty("text", Required = Required.Always)]
        [Required]
        public Text Text { get; set; } = new Text();

        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Images Images { get; set; }

        [JsonProperty("carrier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Carrier Carrier { get; set; }

        [JsonProperty("perso_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_personalizationPerso_type? Perso_type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}