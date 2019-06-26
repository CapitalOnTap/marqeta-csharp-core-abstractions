using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Other_poi
    {
        [JsonProperty("allow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow { get; set; } = true;

        [JsonProperty("card_presence_required", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Card_presence_required { get; set; } = false;

        [JsonProperty("cardholder_presence_required", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cardholder_presence_required { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}