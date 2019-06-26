using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Pagination
    {
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("start_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Start_index { get; set; }

        [JsonProperty("end_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? End_index { get; set; }

        [JsonProperty("is_more", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_more { get; set; } = false;

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> Data { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}