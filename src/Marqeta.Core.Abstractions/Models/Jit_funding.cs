using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Jit_funding
    {
        [JsonProperty("paymentcard_funding_source", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Jit_funding_paymentcard_funding_source Paymentcard_funding_source { get; set; }

        [JsonProperty("programgateway_funding_source", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Jit_funding_programgateway_funding_source Programgateway_funding_source { get; set; }

        [JsonProperty("program_funding_source", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Jit_funding_program_funding_source Program_funding_source { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}