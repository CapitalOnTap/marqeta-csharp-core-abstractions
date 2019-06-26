using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Offer_order_response
    {
        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Business_token { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        [JsonProperty("order_balances", Required = Required.Always)]
        [Required]
        public Offer_order_balances Order_balances { get; set; } = new Offer_order_balances();

        [JsonProperty("order_aggregated_balances", Required = Required.Always)]
        [Required]
        public Offer_order_aggregated_balances Order_aggregated_balances { get; set; } =
            new Offer_order_aggregated_balances();

        [JsonProperty("funding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Funding Funding { get; set; }

        [JsonProperty("offer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Offer_model Offer { get; set; }

        [JsonProperty("last_transaction_date", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_transaction_date { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}