using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Financial_request_model
    {
        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("card_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_token { get; set; }

        [JsonProperty("pin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(15, MinimumLength = 1)]
        public string Pin { get; set; }

        [JsonProperty("mid", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Mid { get; set; }

        [JsonProperty("cash_back_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cash_back_amount { get; set; }

        [JsonProperty("is_pre_auth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_pre_auth { get; set; } = false;

        [JsonProperty("card_acceptor", Required = Required.Always)]
        [Required]
        public Card_acceptor_model Card_acceptor { get; set; } = new Card_acceptor_model();

        [JsonProperty("transaction_options", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Transaction_options Transaction_options { get; set; }

        [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}