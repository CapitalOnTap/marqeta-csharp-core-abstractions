using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Withdrawal_request_model
    {
        [JsonProperty("account_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Withdrawal_request_modelAccount_type? Account_type { get; set; }

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

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("card_acceptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_acceptor_model Card_acceptor { get; set; }

        [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Webhook Webhook { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}