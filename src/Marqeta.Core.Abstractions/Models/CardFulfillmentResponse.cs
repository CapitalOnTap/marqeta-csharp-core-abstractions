using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CardFulfillmentResponse
    {
        [JsonProperty("shipping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ShippingInformationResponse Shipping { get; set; }

        [JsonProperty("card_personalization", Required = Required.Always)]
        [Required]
        public Card_personalization Card_personalization { get; set; } = new Card_personalization();

        [JsonProperty("card_fulfillment_reason", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardFulfillmentResponseCard_fulfillment_reason? Card_fulfillment_reason { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}