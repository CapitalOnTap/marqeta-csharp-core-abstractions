using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class GLEntry
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        [JsonProperty("credit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Credit { get; set; } = false;

        [JsonProperty("layer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Layer { get; set; }

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount Account { get; set; }

        [JsonProperty("transaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GLTransaction Transaction { get; set; }

        [JsonProperty("balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Balance { get; set; }

        [JsonProperty("dealLog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DealLog DealLog { get; set; }

        [JsonProperty("networkTranType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NetworkTranType NetworkTranType { get; set; }

        [JsonProperty("impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Impact { get; set; }

        [JsonProperty("debit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Debit { get; set; } = false;

        [JsonProperty("increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Increase { get; set; } = false;

        [JsonProperty("decrease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Decrease { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}