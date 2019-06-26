using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Bank_account_funding_source_model : Funding_source_model
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

        [JsonProperty("name_on_account", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Name_on_account { get; set; }

        [JsonProperty("routing_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Routing_number { get; set; }

        [JsonProperty("verification_status", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Verification_status { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}