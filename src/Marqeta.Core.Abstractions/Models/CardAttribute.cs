using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CardAttribute
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card Card { get; set; }

        [JsonProperty("cardFulfillmentReason", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardAttributeCardFulfillmentReason? CardFulfillmentReason { get; set; }

        [JsonProperty("attributeName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardAttributeAttributeName? AttributeName { get; set; }

        [JsonProperty("attributeValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AttributeValue { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}