using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_response
    {
        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string User_token { get; set; }

        [JsonProperty("card_product_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Card_product_token { get; set; }

        [JsonProperty("last_four", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_responseLast_four Last_four { get; set; }

        [JsonProperty("pan", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Pan { get; set; }

        [JsonProperty("expiration", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Expiration { get; set; }

        [JsonProperty("expiration_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Expiration_time { get; set; }

        [JsonProperty("cvv_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cvv_number { get; set; }

        [JsonProperty("chip_cvv_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Chip_cvv_number { get; set; }

        [JsonProperty("barcode", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Barcode { get; set; }

        [JsonProperty("pin_is_set", Required = Required.Always)]
        public bool Pin_is_set { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_responseState State { get; set; }

        [JsonProperty("state_reason", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string State_reason { get; set; }

        [JsonProperty("fulfillment_status", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_responseFulfillment_status Fulfillment_status { get; set; }

        [JsonProperty("reissue_pan_from_card_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Reissue_pan_from_card_token { get; set; }

        [JsonProperty("fulfillment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardFulfillmentResponse Fulfillment { get; set; }

        [JsonProperty("bulk_issuance_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bulk_issuance_token { get; set; }

        [JsonProperty("translate_pin_from_card_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Translate_pin_from_card_token { get; set; }

        [JsonProperty("activation_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Activation_actions Activation_actions { get; set; }

        [JsonProperty("instrument_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_responseInstrument_type? Instrument_type { get; set; }

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Metadata { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}