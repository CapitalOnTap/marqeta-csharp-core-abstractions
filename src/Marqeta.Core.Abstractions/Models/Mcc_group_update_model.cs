using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Mcc_group_update_model
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("mccs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Mccs { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Config Config { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}