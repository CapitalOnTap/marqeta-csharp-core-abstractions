using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CompositeAccount
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created { get; set; }

        [JsonProperty("expiration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Expiration { get; set; }

        [JsonProperty("currencyCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        [JsonProperty("networkTranType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NetworkTranType NetworkTranType { get; set; }

        [JsonProperty("parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CompositeAccount Parent { get; set; }

        [JsonProperty("root", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CompositeAccount Root { get; set; }

        [JsonProperty("children0", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> Children0 { get; set; }

        [JsonProperty("markerClass", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkerClass { get; set; } = false;

        [JsonProperty("markerAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompositeAccountMarkerAccount? MarkerAccount { get; set; }

        [JsonProperty("debit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Debit { get; set; } = false;

        [JsonProperty("credit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Credit { get; set; } = false;

        [JsonProperty("chart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chart { get; set; } = false;

        [JsonProperty("finalAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FinalAccount { get; set; } = false;

        [JsonProperty("typeAsString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TypeAsString { get; set; }

        [JsonProperty("cardholderAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CardholderAccount { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}