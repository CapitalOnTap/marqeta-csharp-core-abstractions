using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class NetworkTranType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NetworkTranTypeNetwork? Network { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("sourceAcct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAcct { get; set; }

        [JsonProperty("destAcct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DestAcct { get; set; }

        [JsonProperty("networkTranGroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NetworkTranGroup NetworkTranGroup { get; set; }

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("param", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}