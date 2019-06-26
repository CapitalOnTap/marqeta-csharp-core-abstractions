using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Real_time_standin_criteria
    {
        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        [JsonProperty("include_connection_errors", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_connection_errors { get; set; } = false;

        [JsonProperty("include_response_timeouts", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_response_timeouts { get; set; } = false;

        [JsonProperty("include_application_errors", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_application_errors { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}