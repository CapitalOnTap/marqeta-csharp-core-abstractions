using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Bulk_request_model
    {
        [JsonProperty("user_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> User_tokens { get; set; }

        [JsonProperty("business_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Business_tokens { get; set; }

        [JsonProperty("card_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Card_tokens { get; set; }

        [JsonProperty("kyc_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Kyc_tokens { get; set; }

        [JsonProperty("dda_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [MinLength(1)]
        [MaxLength(500)]
        public ICollection<string> Dda_tokens { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}