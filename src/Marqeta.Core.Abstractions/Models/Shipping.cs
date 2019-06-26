using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Shipping
    {
        [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ShippingMethod? Method { get; set; }

        [JsonProperty("return_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Fulfillment_address_request Return_address { get; set; }

        [JsonProperty("recipient_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Fulfillment_address_request Recipient_address { get; set; }

        [JsonProperty("care_of_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Care_of_line { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}