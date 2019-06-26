using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Auth_user_request
    {
        [JsonProperty("password", Required = Required.Always)]
        [Required]
        [StringLength(32, MinimumLength = 1)]
        public string Password { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("roles", Required = Required.Always)]
        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Roles { get; set; } = new Collection<string>();

        [JsonProperty("username", Required = Required.Always)]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Username { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}