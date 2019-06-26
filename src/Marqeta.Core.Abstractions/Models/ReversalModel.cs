using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ReversalModel
    {
        [JsonProperty("network_fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Network_fee_model> Network_fees { get; set; }

        [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }

        [JsonProperty("original_transaction_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Original_transaction_token { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("find_original_window_days", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Find_original_window_days { get; set; }

        [JsonProperty("is_advice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_advice { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}