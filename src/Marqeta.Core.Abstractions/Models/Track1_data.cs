using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Track1_data
    {
        [JsonProperty("cvv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(3)]
        public string Cvv { get; set; }

        [JsonProperty("atc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(4, MinimumLength = 4)]
        public string Atc { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}