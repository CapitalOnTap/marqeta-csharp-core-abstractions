using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Transaction_metadata
    {
        [JsonProperty("transaction_category", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Transaction_metadataTransaction_category? Transaction_category { get; set; }

        [JsonProperty("payment_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Transaction_metadataPayment_channel? Payment_channel { get; set; }

        [JsonProperty("cross_border_transaction", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cross_border_transaction { get; set; } = false;

        [JsonProperty("authorization_life_cyle", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Authorization_life_cyle { get; set; }

        [JsonProperty("is_lodging_auto_rental", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_lodging_auto_rental { get; set; } = false;

        [JsonProperty("lodging_auto_rental_start_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lodging_auto_rental_start_date { get; set; }

        [JsonProperty("transit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Transit Transit { get; set; }

        [JsonProperty("airline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Airline Airline { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}