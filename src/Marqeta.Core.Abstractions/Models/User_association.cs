using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class User_association
    {
        [JsonProperty("single_inventory_user", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Single_inventory_user { get; set; } = false;

        [JsonProperty("single_inventory_user_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Single_inventory_user_token { get; set; } = "false";

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}