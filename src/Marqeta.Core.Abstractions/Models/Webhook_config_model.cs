using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Webhook_config_model
    {
        [JsonProperty("url", Required = Required.Always)]
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string Url { get; set; }

        [JsonProperty("secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        [JsonProperty("basic_auth_username", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Basic_auth_username { get; set; }

        [JsonProperty("basic_auth_password", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Basic_auth_password { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}