using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Expiration_offset
    {
        /// <summary>Should be specified if a value is provided.  Defaults to YEARS</summary>
        [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Expiration_offsetUnit? Unit { get; set; }

        /// <summary>Should be specified if unit is provided. Defaults to 4</summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; }

        [JsonProperty("min_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Min_offset Min_offset { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}