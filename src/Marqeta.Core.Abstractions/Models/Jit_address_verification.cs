using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Jit_address_verification
    {
        [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Avs_information Request { get; set; }

        [JsonProperty("issuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Address_verification_source Issuer { get; set; }

        [JsonProperty("gateway", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Address_verification_source Gateway { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}