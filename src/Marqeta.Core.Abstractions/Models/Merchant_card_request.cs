using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Merchant_card_request
    {
        [JsonProperty("card_product_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_product_token { get; set; }

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Metadata { get; set; }

        [JsonProperty("expiration_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Expiration_offset Expiration_offset { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}