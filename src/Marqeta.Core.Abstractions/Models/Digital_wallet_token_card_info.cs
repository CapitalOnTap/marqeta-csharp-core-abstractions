using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token_card_info
    {
        [JsonProperty("pan", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(19)]
        public string Pan { get; set; }

        [JsonProperty("exp_month", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(2)]
        public string Exp_month { get; set; }

        [JsonProperty("exp_year", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(2)]
        public string Exp_year { get; set; }

        [JsonProperty("cvv", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(3)]
        public string Cvv { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}