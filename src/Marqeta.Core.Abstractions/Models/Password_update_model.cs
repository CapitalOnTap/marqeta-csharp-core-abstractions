using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Password_update_model
    {
        [JsonProperty("new_password", Required = Required.Always)]
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string New_password { get; set; }

        [JsonProperty("current_password", Required = Required.Always)]
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string Current_password { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}