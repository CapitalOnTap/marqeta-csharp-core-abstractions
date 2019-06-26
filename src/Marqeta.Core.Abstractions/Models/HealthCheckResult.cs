using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class HealthCheckResult
    {
        [JsonProperty("component", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Component { get; set; }

        [JsonProperty("healthy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Healthy { get; set; } = false;

        [JsonProperty("fatal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fatal { get; set; } = false;

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}