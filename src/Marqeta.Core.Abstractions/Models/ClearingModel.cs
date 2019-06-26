using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ClearingModel
    {
        [JsonProperty("network_fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Network_fee_model> Network_fees { get; set; }

        [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }

        [JsonProperty("is_refund", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_refund { get; set; } = false;

        [JsonProperty("force_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_post { get; set; } = false;

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("original_transaction_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Original_transaction_token { get; set; }

        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50, MinimumLength = 1)]
        public string Mid { get; set; }

        [JsonProperty("card_acceptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_acceptor_model Card_acceptor { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}