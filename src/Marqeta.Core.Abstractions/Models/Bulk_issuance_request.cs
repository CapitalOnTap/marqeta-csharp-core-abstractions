using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Bulk_issuance_request
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("fulfillment", Required = Required.Always)]
        [Required]
        public Fulfillment Fulfillment { get; set; } = new Fulfillment();

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonProperty("card_product_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_product_token { get; set; }

        [JsonProperty("card_allocation", Required = Required.Always)]
        [Range(int.MinValue, 50000)]
        public int Card_allocation { get; set; }

        [JsonProperty("user_association", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public User_association User_association { get; set; }

        [JsonProperty("name_line_1_numeric_postfix", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Name_line_1_numeric_postfix { get; set; } = false;

        [JsonProperty("expiration_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Expiration_offset Expiration_offset { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}