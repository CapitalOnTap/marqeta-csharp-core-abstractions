using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("card_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Card_token { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("state_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State_reason { get; set; }

        [JsonProperty("fulfillment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fulfillment_status { get; set; }

        [JsonProperty("issuer_eligibility_decision", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer_eligibility_decision { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonProperty("token_service_provider", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Token_service_provider Token_service_provider { get; set; }

        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Device Device { get; set; }

        [JsonProperty("wallet_provider_profile", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Wallet_provider_profile Wallet_provider_profile { get; set; }

        [JsonProperty("address_verification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Address_verification Address_verification { get; set; }

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public User_card_holder_response User { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}