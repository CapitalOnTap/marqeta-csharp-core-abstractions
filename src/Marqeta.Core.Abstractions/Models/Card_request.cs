﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_request
    {
        [JsonProperty("card_product_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_product_token { get; set; }

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Metadata { get; set; }

        [JsonProperty("expiration_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Expiration_offset Expiration_offset { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string User_token { get; set; }

        [JsonProperty("fulfillment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Fulfillment Fulfillment { get; set; }

        [JsonProperty("reissue_pan_from_card_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Reissue_pan_from_card_token { get; set; }

        [JsonProperty("translate_pin_from_card_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Translate_pin_from_card_token { get; set; }

        [JsonProperty("activation_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Activation_actions Activation_actions { get; set; }

        [JsonProperty("bulk_issuance_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bulk_issuance_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}