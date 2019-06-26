using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_acceptor_model
    {
        [JsonProperty("mcc", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(5)]
        public string Mcc { get; set; }

        [JsonProperty("partial_approval_capable", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partial_approval_capable { get; set; } = false;

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Name { get; set; }

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Address { get; set; }

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(10)]
        public string Zip { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("ecommerce_security_level_indicator", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Ecommerce_security_level_indicator { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}