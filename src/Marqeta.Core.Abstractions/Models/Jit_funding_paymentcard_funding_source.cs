using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Jit_funding_paymentcard_funding_source
    {
        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        [JsonProperty("refunds_destination", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Jit_funding_paymentcard_funding_sourceRefunds_destination? Refunds_destination { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}