using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Base_ach_request_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("account_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_number { get; set; }

        [JsonProperty("routing_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Routing_number { get; set; }

        [JsonProperty("name_on_account", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name_on_account { get; set; }

        [JsonProperty("account_type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Base_ach_request_modelAccount_type Account_type { get; set; }

        [JsonProperty("bank_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bank_name { get; set; }

        [JsonProperty("verification_override", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verification_override { get; set; } = false;

        [JsonProperty("verification_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Verification_notes { get; set; }

        [JsonProperty("is_default_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_default_account { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}