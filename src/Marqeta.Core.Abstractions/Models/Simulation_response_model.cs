using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Simulation_response_model
    {
        [JsonProperty("transaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Transaction_model Transaction { get; set; }

        [JsonProperty("raw_iso8583", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Raw_iso8583 { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}