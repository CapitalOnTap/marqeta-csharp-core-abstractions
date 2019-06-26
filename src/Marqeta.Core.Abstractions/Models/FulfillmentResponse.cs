using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class FulfillmentResponse
    {
        [JsonProperty("shipping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ShippingInformationResponse Shipping { get; set; }

        [JsonProperty("card_personalization", Required = Required.Always)]
        [Required]
        public Card_personalization Card_personalization { get; set; } = new Card_personalization();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}