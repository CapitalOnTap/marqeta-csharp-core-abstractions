using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class GLTransaction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; }

        [JsonProperty("postDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PostDate { get; set; }

        [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        [JsonProperty("journal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Journal Journal { get; set; }

        [JsonProperty("entries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> Entries { get; set; }

        [JsonProperty("adjustmentEntries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> AdjustmentEntries { get; set; }

        [JsonProperty("issuerFeesCreditAmount", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? IssuerFeesCreditAmount { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}