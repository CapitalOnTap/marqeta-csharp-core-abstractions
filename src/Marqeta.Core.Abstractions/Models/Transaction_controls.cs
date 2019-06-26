using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Transaction_controls
    {
        [JsonProperty("accepted_countries_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Accepted_countries_token { get; set; }

        [JsonProperty("always_require_pin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Always_require_pin { get; set; } = false;

        [JsonProperty("always_require_icc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Always_require_icc { get; set; } = false;

        [JsonProperty("allow_gpa_auth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_gpa_auth { get; set; } = false;

        [JsonProperty("require_card_not_present_card_security_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Require_card_not_present_card_security_code { get; set; } = false;

        [JsonProperty("allow_mcc_group_authorization_controls", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_mcc_group_authorization_controls { get; set; } = false;

        [JsonProperty("allow_first_pin_set_via_financial_transaction", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_first_pin_set_via_financial_transaction { get; set; } = false;

        [JsonProperty("ignore_card_suspended_state", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_card_suspended_state { get; set; } = false;

        [JsonProperty("allow_chip_fallback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_chip_fallback { get; set; } = false;

        [JsonProperty("allow_network_load", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_network_load { get; set; } = false;

        [JsonProperty("allow_network_load_card_activation", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_network_load_card_activation { get; set; } = false;

        [JsonProperty("allow_quasi_cash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_quasi_cash { get; set; } = false;

        [JsonProperty("enable_partial_auth_approval", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_partial_auth_approval { get; set; } = false;

        [JsonProperty("address_verification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Avs_controls Address_verification { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}