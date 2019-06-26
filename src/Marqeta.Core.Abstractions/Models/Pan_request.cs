using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Pan_request
    {
        [JsonProperty("pan", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Pan { get; set; }

        [JsonProperty("cvv_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cvv_number { get; set; }

        [JsonProperty("expiration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Expiration { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}