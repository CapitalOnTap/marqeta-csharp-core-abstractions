using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserValidationResponse
    {
        [JsonProperty("birth_date", Required = Required.Always)]
        public bool Birth_date { get; set; }

        [JsonProperty("phone", Required = Required.Always)]
        public bool Phone { get; set; }

        [JsonProperty("ssn", Required = Required.Always)]
        public bool Ssn { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}