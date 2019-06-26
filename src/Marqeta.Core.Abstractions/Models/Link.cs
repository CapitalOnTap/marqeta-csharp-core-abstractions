using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Link
    {
        [JsonProperty("rel", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Rel { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Method { get; set; }

        [JsonProperty("href", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Href { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}