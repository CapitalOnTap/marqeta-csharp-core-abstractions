using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Gateway_program_funding_source_response
    {
        [JsonProperty("name", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [JsonProperty("url", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        [JsonProperty("version", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Version { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = true;

        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("account", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account { get; set; }

        [JsonProperty("basic_auth_username", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Basic_auth_username { get; set; }

        [JsonProperty("basic_auth_password", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Basic_auth_password { get; set; }

        [JsonProperty("timeout_millis", Required = Required.Always)]
        public long Timeout_millis { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}