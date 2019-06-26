using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Jit_funding_programgateway_funding_source
    {
        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        [JsonProperty("funding_source_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Funding_source_token { get; set; }

        [JsonProperty("refunds_destination", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Jit_funding_programgateway_funding_sourceRefunds_destination? Refunds_destination { get; set; }

        [JsonProperty("always_fund", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Always_fund { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}