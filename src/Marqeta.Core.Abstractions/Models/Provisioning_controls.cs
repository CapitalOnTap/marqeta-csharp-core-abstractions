using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Provisioning_controls
    {
        [JsonProperty("manual_entry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Manual_entry Manual_entry { get; set; }

        [JsonProperty("wallet_provider_card_on_file", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Wallet_provider_card_on_file Wallet_provider_card_on_file { get; set; }

        [JsonProperty("in_app_provisioning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public In_app_provisioning In_app_provisioning { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}