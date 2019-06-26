using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Payment_card_funding_source_model : Funding_source_model
    {
        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Business_token { get; set; }

        [JsonProperty("account_suffix", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_suffix { get; set; }

        [JsonProperty("account_type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_type { get; set; }

        [JsonProperty("exp_date", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Exp_date { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}