using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Program_transfer_response
    {
        [JsonProperty("fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Fee_detail> Fees { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("type_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Type_token { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Business_token { get; set; }

        [JsonProperty("transaction_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Transaction_token { get; set; }

        [JsonProperty("currency_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(99, MinimumLength = 1)]
        public string Memo { get; set; }

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
        public string Tags { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("jit_funding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Jit_funding_api Jit_funding { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}