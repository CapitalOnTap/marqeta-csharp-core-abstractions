using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BillPaymentCompletionRequest
    {
        [JsonProperty("network_reference_id", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Network_reference_id { get; set; }

        [JsonProperty("original_transaction_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Original_transaction_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}