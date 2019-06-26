using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Journal
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start { get; set; }

        [JsonProperty("end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; }

        [JsonProperty("lockDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LockDate { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closed { get; set; } = false;

        [JsonProperty("chart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Account Chart { get; set; }

        [JsonProperty("permissions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> Permissions { get; set; }

        [JsonProperty("layers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> Layers { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}