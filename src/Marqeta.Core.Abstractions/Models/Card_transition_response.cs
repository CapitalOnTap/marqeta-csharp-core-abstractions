using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_transition_response
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("card_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_token { get; set; }

        [JsonProperty("user_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string User_token { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_transition_responseState State { get; set; }

        [JsonProperty("reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        [JsonProperty("reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_transition_responseReason_code? Reason_code { get; set; }

        [JsonProperty("channel", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_transition_responseChannel Channel { get; set; }

        [JsonProperty("fulfillment_status", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_transition_responseFulfillment_status Fulfillment_status { get; set; }

        [JsonProperty("validations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValidationsResponse Validations { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_transition_responseType Type { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("card_product_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Card_product_token { get; set; }

        [JsonProperty("last_four", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_transition_responseLast_four Last_four { get; set; }

        [JsonProperty("pan", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Pan { get; set; }

        [JsonProperty("expiration", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Expiration { get; set; }

        [JsonProperty("expiration_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Expiration_time { get; set; }

        [JsonProperty("barcode", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Barcode { get; set; }

        [JsonProperty("pin_is_set", Required = Required.Always)]
        public bool Pin_is_set { get; set; }

        [JsonProperty("fulfillment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Fulfillment Fulfillment { get; set; }

        [JsonProperty("bulk_issuance_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bulk_issuance_token { get; set; }

        [JsonProperty("reissue_pan_from_card_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Reissue_pan_from_card_token { get; set; }

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Cardholder_metadata User { get; set; }

        [JsonProperty("card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_metadata Card { get; set; }

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}