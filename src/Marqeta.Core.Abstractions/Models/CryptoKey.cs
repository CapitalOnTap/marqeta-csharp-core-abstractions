using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CryptoKey
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("cryptoKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CryptoKey CryptoKey1 { get; set; }

        [JsonProperty("network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Network { get; set; }

        [JsonProperty("keyType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeyType { get; set; }

        [JsonProperty("keyValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeyValue { get; set; }

        [JsonProperty("keyIndicator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeyIndicator { get; set; }

        [JsonProperty("parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CryptoKey Parent { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("modifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ModifiedTime { get; set; }

        [JsonProperty("zoneKeys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> ZoneKeys { get; set; }

        [JsonProperty("cryptoKeys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> CryptoKeys { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}