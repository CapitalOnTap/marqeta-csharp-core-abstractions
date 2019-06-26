using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Token_request
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Business_token { get; set; }

        [JsonProperty("account_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_number { get; set; }

        [JsonProperty("cvv_number", Required = Required.Always)]
        [Required]
        [StringLength(4, MinimumLength = 3)]
        public string Cvv_number { get; set; }

        [JsonProperty("exp_date", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Exp_date { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [JsonProperty("postal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Postal_code { get; set; }

        [JsonProperty("is_default_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_default_account { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}