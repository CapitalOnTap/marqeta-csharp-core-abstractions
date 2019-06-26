using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Program_reserve_account_balance
    {
        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency_code { get; set; }

        [JsonProperty("ledger_balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Ledger_balance { get; set; }

        [JsonProperty("available_balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Available_balance { get; set; }

        [JsonProperty("credit_balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Credit_balance { get; set; }

        [JsonProperty("pending_credits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pending_credits { get; set; }

        [JsonProperty("balances", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, Program_reserve_account_balance> Balances { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}