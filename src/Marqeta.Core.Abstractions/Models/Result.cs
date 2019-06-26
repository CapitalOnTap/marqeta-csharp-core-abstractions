using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Result
    {
        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("codes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Result_code> Codes { get; set; }

        [JsonProperty("failed_questions_count", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Failed_questions_count { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}