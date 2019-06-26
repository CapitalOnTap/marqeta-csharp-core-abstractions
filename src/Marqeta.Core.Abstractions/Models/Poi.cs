using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Poi
    {
        [JsonProperty("other", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Other_poi Other { get; set; }

        [JsonProperty("ecommerce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ecommerce { get; set; } = true;

        [JsonProperty("atm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Atm { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}