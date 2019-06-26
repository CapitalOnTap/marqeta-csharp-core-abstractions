using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Funding
    {
        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("source", Required = Required.Always)]
        [Required]
        public Funding_source_model Source { get; set; } = new Funding_source_model();

        [JsonProperty("source_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardholderAddressResponse Source_address { get; set; }

        [JsonProperty("gateway_log", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gateway_log_model Gateway_log { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}