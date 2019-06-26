using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Deposit_account
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Business_token { get; set; }

        [JsonProperty("account_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_number { get; set; }

        [JsonProperty("routing_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Routing_number { get; set; }

        [JsonProperty("allow_immediate_credit", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_immediate_credit { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}