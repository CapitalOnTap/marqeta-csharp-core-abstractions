using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Available
    {
        /// <summary>Uses available</summary>
        [JsonProperty("uses", Required = Required.Always)]
        public int Uses { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Amount { get; set; }

        /// <summary>Days remaining</summary>
        [JsonProperty("days_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Days_remaining { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}