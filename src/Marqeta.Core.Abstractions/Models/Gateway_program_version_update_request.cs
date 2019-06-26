using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Gateway_program_version_update_request
    {
        [JsonProperty("version", Required = Required.Always)]
        [Required]
        [StringLength(25, MinimumLength = 1)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gateway_program_version_update_requestVersion Version { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}