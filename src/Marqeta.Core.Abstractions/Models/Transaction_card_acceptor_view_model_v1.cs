using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Transaction_card_acceptor_view_model_v1
    {
        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        [JsonProperty("mcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        [JsonProperty("network_mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Network_mid { get; set; }

        [JsonProperty("mcc_groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Mcc_groups { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [JsonProperty("postal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Postal_code { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("poi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Terminal_model Poi { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}