using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class KYCQuestion
    {
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("question", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Question { get; set; }

        [JsonProperty("answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Answers { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}