using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Create_caches_request
    {
        [JsonProperty("transactions", Required = Required.Always)]
        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Transactions { get; set; } = new Collection<string>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}