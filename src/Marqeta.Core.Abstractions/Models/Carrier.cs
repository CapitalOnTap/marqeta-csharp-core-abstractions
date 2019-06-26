using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Carrier
    {
        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Template_id { get; set; }

        [JsonProperty("logo_file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Logo_file { get; set; }

        [JsonProperty("logo_thumbnail_file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Logo_thumbnail_file { get; set; }

        [JsonProperty("message_file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Message_file { get; set; }

        [JsonProperty("message_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Message_line { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}