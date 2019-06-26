using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Mcc_group_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string Name { get; set; }

        [JsonProperty("mccs", Required = Required.Always)]
        [Required]
        [MaxLength(500)]
        public ICollection<object> Mccs { get; set; } = new Collection<object>();

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Config Config { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}