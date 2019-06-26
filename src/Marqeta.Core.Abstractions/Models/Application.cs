using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Application
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("program", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Program { get; set; }

        [JsonProperty("environment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Environment { get; set; }

        [JsonProperty("program_short_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Program_short_code { get; set; }

        [JsonProperty("client_api_base_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Client_api_base_url { get; set; }

        [JsonProperty("assets_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets_url { get; set; }

        [JsonProperty("access_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Access_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}