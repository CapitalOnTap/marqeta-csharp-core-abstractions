using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Bulk_issuance_response
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("fulfillment", Required = Required.Always)]
        [Required]
        public FulfillmentResponse Fulfillment { get; set; } = new FulfillmentResponse();

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonProperty("card_product_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_product_token { get; set; }

        [JsonProperty("card_allocation", Required = Required.Always)]
        [Range(int.MinValue, 50000)]
        public int Card_allocation { get; set; }

        [JsonProperty("user_association", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public User_association User_association { get; set; }

        [JsonProperty("name_line_1_numeric_postfix", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Name_line_1_numeric_postfix { get; set; } = false;

        [JsonProperty("expiration_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Expiration_offset Expiration_offset { get; set; }

        [JsonProperty("cards_processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cards_processed { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("name_line1_start_index", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Name_line1_start_index { get; set; }

        [JsonProperty("name_line1_end_index", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Name_line1_end_index { get; set; }

        [JsonProperty("card_fulfillment_time", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Card_fulfillment_time { get; set; }

        [JsonProperty("provider_ship_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Provider_ship_date { get; set; }

        [JsonProperty("provider_shipping_method", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Provider_shipping_method { get; set; }

        [JsonProperty("provider_tracking_number", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Provider_tracking_number { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}