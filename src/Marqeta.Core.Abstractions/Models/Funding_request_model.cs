using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Funding_request_model
    {
        [JsonProperty("user_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string User_token { get; set; }

        [JsonProperty("order_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Order_number { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Amount { get; set; }

        [JsonProperty("funding_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Funding_source { get; set; }

        [JsonProperty("funding_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Funding_address { get; set; }

        [JsonProperty("fundgpadetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fundgpadetail { get; set; }

        [JsonProperty("order_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Order_token { get; set; }

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}