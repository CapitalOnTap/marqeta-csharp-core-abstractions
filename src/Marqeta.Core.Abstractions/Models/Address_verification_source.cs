using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Address_verification_source
    {
        [JsonProperty("on_file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Avs_information On_file { get; set; }

        [JsonProperty("response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Response Response { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}