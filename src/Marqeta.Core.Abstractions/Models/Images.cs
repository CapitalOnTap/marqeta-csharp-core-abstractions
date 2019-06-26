using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Images
    {
        [JsonProperty("card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Images_card Card { get; set; }

        [JsonProperty("carrier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ImagesCarrier Carrier { get; set; }

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Images_signature Signature { get; set; }

        [JsonProperty("carrier_return_window", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Images_carrier_return_window Carrier_return_window { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}