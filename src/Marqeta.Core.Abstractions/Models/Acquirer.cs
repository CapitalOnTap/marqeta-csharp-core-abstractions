using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Acquirer
    {
        [JsonProperty("institution_country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Institution_country { get; set; }

        [JsonProperty("network_international_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Network_international_id { get; set; }

        [JsonProperty("institution_id_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Institution_id_code { get; set; }

        [JsonProperty("retrieval_reference_number", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Retrieval_reference_number { get; set; }

        [JsonProperty("system_trace_audit_number", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string System_trace_audit_number { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}