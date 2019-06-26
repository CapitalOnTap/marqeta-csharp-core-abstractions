using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Offer_order_balances
    {
        [JsonProperty("currency_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }

        [JsonProperty("ledger_balance", Required = Required.Always)]
        public double Ledger_balance { get; set; }

        [JsonProperty("available_balance", Required = Required.Always)]
        public double Available_balance { get; set; }

        [JsonProperty("credit_balance", Required = Required.Always)]
        public double Credit_balance { get; set; }

        [JsonProperty("pending_credits", Required = Required.Always)]
        public double Pending_credits { get; set; }

        [JsonProperty("impacted_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Impacted_amount { get; set; }

        [JsonProperty("balances", Required = Required.Always)]
        [Required]
        public IDictionary<string, Offer_order_balances> Balances { get; set; } =
            new Dictionary<string, Offer_order_balances>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}