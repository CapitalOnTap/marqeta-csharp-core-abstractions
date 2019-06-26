using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Cardholder_balances
    {
        [JsonProperty("gpa", Required = Required.Always)]
        [Required]
        public Cardholder_balance Gpa { get; set; } = new Cardholder_balance();

        [JsonProperty("links", Required = Required.Always)]
        [Required]
        public ICollection<Link> Links { get; set; } = new Collection<Link>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}