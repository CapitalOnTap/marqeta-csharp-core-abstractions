using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BulkCardOrder
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("cardsOrdered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CardsOrdered { get; set; }

        [JsonProperty("cardsProcessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CardsProcessed { get; set; }

        [JsonProperty("singleInventoryUser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SingleInventoryUser { get; set; } = false;

        [JsonProperty("inventoryCardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UserCardHolder InventoryCardHolder { get; set; }

        [JsonProperty("nameLine1NumericPostfix", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? NameLine1NumericPostfix { get; set; } = false;

        [JsonProperty("nameLine1NumericStartIndex", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? NameLine1NumericStartIndex { get; set; }

        [JsonProperty("nameLine1NumericEndIndex", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? NameLine1NumericEndIndex { get; set; }

        [JsonProperty("cardProduct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_product CardProduct { get; set; }

        [JsonProperty("shippingMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public BulkCardOrderShippingMethod? ShippingMethod { get; set; }

        [JsonProperty("returnAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FulfillmentAddress ReturnAddress { get; set; }

        [JsonProperty("recipientAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FulfillmentAddress RecipientAddress { get; set; }

        [JsonProperty("careOfLine", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CareOfLine { get; set; }

        [JsonProperty("cardPersonalization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_personalization CardPersonalization { get; set; }

        [JsonProperty("fileProcessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FileProcessed { get; set; } = false;

        [JsonProperty("fulfillmentTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FulfillmentTime { get; set; }

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonProperty("expirationOffsetValue", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpirationOffsetValue { get; set; }

        [JsonProperty("expirationOffsetUnit", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public BulkCardOrderExpirationOffsetUnit? ExpirationOffsetUnit { get; set; }

        [JsonProperty("providerShipDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ProviderShipDate { get; set; }

        [JsonProperty("providerShippingMethod", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderShippingMethod { get; set; }

        [JsonProperty("providerTrackingNumber", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderTrackingNumber { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}