using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_options
    {
        [JsonProperty("cvv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(3)]
        public string Cvv { get; set; }

        [JsonProperty("card_present", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Card_present { get; set; } = false;

        [JsonProperty("expiration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(4, MinimumLength = 4)]
        public string Expiration { get; set; }

        [JsonProperty("billing_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BillingAddress Billing_address { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}