using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Gateway_clearing_request
    {
        [JsonProperty("original_transaction_token", Required = Required.Always)]
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string Original_transaction_token { get; set; }

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public double? Amount { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}