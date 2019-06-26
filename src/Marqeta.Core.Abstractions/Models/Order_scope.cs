using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Order_scope
    {
        [JsonProperty("gpa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gpa Gpa { get; set; }

        [JsonProperty("msa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Msa Msa { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}