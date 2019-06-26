using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Text
    {
        [JsonProperty("name_line_1", Required = Required.Always)]
        [Required]
        public Text_value Name_line_1 { get; set; } = new Text_value();

        [JsonProperty("name_line_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Text_value Name_line_2 { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}