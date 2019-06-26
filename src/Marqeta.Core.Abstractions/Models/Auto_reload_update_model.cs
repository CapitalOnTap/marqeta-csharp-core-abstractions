using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Auto_reload_update_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = true;

        [JsonProperty("funding_source_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Funding_source_token { get; set; }

        [JsonProperty("funding_source_address_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Funding_source_address_token { get; set; }

        [JsonProperty("association", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Auto_reload_association Association { get; set; }

        [JsonProperty("order_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Order_scope Order_scope { get; set; }

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}