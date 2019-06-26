using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_product
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("idempotentHash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdempotentHash { get; set; }

        [JsonProperty("fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, double> Fees { get; set; }

        [JsonProperty("issuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Issuer Issuer { get; set; }

        [JsonProperty("velocityProfiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> VelocityProfiles { get; set; }

        [JsonProperty("issuedAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount IssuedAccount { get; set; }

        [JsonProperty("feeAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount FeeAccount { get; set; }

        [JsonProperty("cardProductConfigs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CardProductConfig> CardProductConfigs { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("maskBinPrefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MaskBinPrefix { get; set; } = false;

        [JsonProperty("returnAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FulfillmentAddress ReturnAddress { get; set; }

        [JsonProperty("recipientAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FulfillmentAddress RecipientAddress { get; set; }

        [JsonProperty("shippingMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_productShippingMethod? ShippingMethod { get; set; }

        [JsonProperty("cardPersonalization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_personalization CardPersonalization { get; set; }

        [JsonProperty("careOfLine", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CareOfLine { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}