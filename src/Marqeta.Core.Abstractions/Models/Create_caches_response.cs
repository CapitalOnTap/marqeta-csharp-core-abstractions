using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Create_caches_response
    {
        [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Created { get; set; }

        [JsonProperty("already_exists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Already_exists { get; set; }

        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Cache_error> Errors { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}