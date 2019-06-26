using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Funding_response_model
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("accounting_balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Accounting_balance { get; set; }

        [JsonProperty("available_balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Available_balance { get; set; }

        [JsonProperty("transaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gatewaylog Transaction { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}