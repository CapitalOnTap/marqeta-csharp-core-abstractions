using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_product_fulfillment
    {
        [JsonProperty("shipping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Shipping Shipping { get; set; }

        [JsonProperty("card_personalization", Required = Required.Always)]
        [Required]
        public Card_personalization Card_personalization { get; set; } = new Card_personalization();

        [JsonProperty("payment_instrument", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_product_fulfillmentPayment_instrument? Payment_instrument { get; set; } =
            Card_product_fulfillmentPayment_instrument.PHYSICAL_MSR;

        [JsonProperty("package_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50, MinimumLength = 1)]
        public string Package_id { get; set; } = "0";

        [JsonProperty("all_zero_card_security_code", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? All_zero_card_security_code { get; set; } = false;

        [JsonProperty("bin_prefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bin_prefix { get; set; }

        [JsonProperty("bulk_ship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bulk_ship { get; set; } = false;

        [JsonProperty("pan_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pan_length { get; set; } = "16";

        [JsonProperty("fulfillment_provider", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_product_fulfillmentFulfillment_provider? Fulfillment_provider { get; set; }

        [JsonProperty("allow_card_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_card_creation { get; set; } = true;

        [JsonProperty("uppercase_name_lines", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Uppercase_name_lines { get; set; } = true;

        [JsonProperty("enable_offline_pin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_offline_pin { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}