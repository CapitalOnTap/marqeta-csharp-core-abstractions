using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Clearing_file_response
    {
        [JsonProperty("clearing_files", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Clearing_file> Clearing_files { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}