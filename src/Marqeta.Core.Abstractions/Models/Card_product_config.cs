using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_product_config
    {
        [JsonProperty("poi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Poi Poi { get; set; }

        [JsonProperty("transaction_controls", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Transaction_controls Transaction_controls { get; set; }

        [JsonProperty("selective_auth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Selective_auth Selective_auth { get; set; }

        [JsonProperty("special", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Special Special { get; set; }

        [JsonProperty("card_life_cycle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_life_cycle Card_life_cycle { get; set; }

        [JsonProperty("clearing_and_settlement", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Clearing_and_settlement Clearing_and_settlement { get; set; }

        [JsonProperty("jit_funding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Jit_funding Jit_funding { get; set; }

        [JsonProperty("digital_wallet_tokenization", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Digital_wallet_tokenization Digital_wallet_tokenization { get; set; }

        [JsonProperty("fulfillment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_product_fulfillment Fulfillment { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}