using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Push_to_card_request
    {
        [JsonProperty("address_1", Required = Required.Always)]
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string Address_1 { get; set; }

        [JsonProperty("address_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
        public string Address_2 { get; set; }

        [JsonProperty("city", Required = Required.Always)]
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required]
        [StringLength(2, MinimumLength = 1)]
        public string State { get; set; }

        [JsonProperty("zip", Required = Required.Always)]
        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string Zip { get; set; }

        [JsonProperty("country", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Country { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("user_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string User_token { get; set; }

        [JsonProperty("name_on_card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Name_on_card { get; set; }

        [JsonProperty("pan", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Pan { get; set; }

        [JsonProperty("cvv", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Cvv { get; set; }

        [JsonProperty("exp_date", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Exp_date { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}