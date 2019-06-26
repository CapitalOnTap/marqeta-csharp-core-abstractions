using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Token_service_provider
    {
        [JsonProperty("token_reference_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_reference_id { get; set; }

        [JsonProperty("pan_reference_id", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Pan_reference_id { get; set; }

        [JsonProperty("correlation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Correlation_id { get; set; }

        [JsonProperty("token_requestor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_requestor_id { get; set; }

        [JsonProperty("token_requestor_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Token_requestor_name { get; set; }

        [JsonProperty("token_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_type { get; set; }

        [JsonProperty("token_pan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_pan { get; set; }

        [JsonProperty("token_expiration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_expiration { get; set; }

        [JsonProperty("token_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_score { get; set; }

        [JsonProperty("token_assurance_level", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Token_assurance_level { get; set; }

        [JsonProperty("token_eligibility_decision", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Token_eligibility_decision { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}