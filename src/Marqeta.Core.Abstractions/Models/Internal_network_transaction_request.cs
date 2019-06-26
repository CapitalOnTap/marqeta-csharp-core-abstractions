using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Internal_network_transaction_request
    {
        [JsonProperty("message", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Message { get; set; }

        [JsonProperty("network", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Network { get; set; }

        [JsonProperty("debit", Required = Required.Always)]
        public bool Debit { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}