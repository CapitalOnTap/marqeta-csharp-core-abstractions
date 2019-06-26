using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Webhook
    {
        [JsonProperty("endpoint", Required = Required.Always)]
        [Required]
        [StringLength(512, MinimumLength = 1)]
        public string Endpoint { get; set; }

        [JsonProperty("username", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Username { get; set; }

        [JsonProperty("password", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Password { get; set; }

        [JsonProperty("secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}