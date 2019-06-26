using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Payment_card_response_model
    {
        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Type { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        [JsonProperty("account_suffix", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_suffix { get; set; }

        [JsonProperty("account_type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_type { get; set; }

        [JsonProperty("active", Required = Required.Always)]
        public bool Active { get; set; }

        [JsonProperty("is_default_account", Required = Required.Always)]
        public bool Is_default_account { get; set; }

        [JsonProperty("exp_date", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Exp_date { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Business_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}