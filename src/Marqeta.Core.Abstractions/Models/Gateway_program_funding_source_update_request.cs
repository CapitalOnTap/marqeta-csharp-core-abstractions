using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Gateway_program_funding_source_update_request
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = true;

        [JsonProperty("url", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(250)]
        public string Url { get; set; }

        [JsonProperty("basic_auth_username", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Basic_auth_username { get; set; }

        [JsonProperty("basic_auth_password", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Basic_auth_password { get; set; }

        [JsonProperty("timeout_millis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(1000.0D, 7000.0D)]
        public long? Timeout_millis { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}