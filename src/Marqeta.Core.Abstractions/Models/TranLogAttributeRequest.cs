using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class TranLogAttributeRequest
    {
        [JsonProperty("transaction_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Transaction_token { get; set; }

        [JsonProperty("attribute_name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Attribute_name { get; set; }

        [JsonProperty("attribute_value", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Attribute_value { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}