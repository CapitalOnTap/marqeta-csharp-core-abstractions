using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Msa
    {
        [JsonProperty("campaign_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Campaign_token { get; set; }

        [JsonProperty("trigger_amount", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Trigger_amount { get; set; }

        [JsonProperty("reload_amount", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Reload_amount { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}