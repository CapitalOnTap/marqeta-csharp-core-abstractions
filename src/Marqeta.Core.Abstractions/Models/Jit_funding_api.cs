using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Jit_funding_api
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(36)]
        public string Token { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Jit_funding_apiMethod Method { get; set; }

        [JsonProperty("user_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(36)]
        public string User_token { get; set; }

        [JsonProperty("acting_user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Acting_user_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Business_token { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Amount { get; set; }

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(99)]
        public string Memo { get; set; }

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Tags { get; set; }

        [JsonProperty("original_jit_funding_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Original_jit_funding_token { get; set; }

        [JsonProperty("incremental_authorization_jit_funding_tokens", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Incremental_authorization_jit_funding_tokens { get; set; }

        [JsonProperty("address_verification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Jit_address_verification Address_verification { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}