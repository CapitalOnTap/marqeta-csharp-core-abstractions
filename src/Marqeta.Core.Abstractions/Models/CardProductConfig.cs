using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CardProductConfig
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("cardproduct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_product Cardproduct { get; set; }

        [JsonProperty("configKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigKey { get; set; }

        [JsonProperty("configValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigValue { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}