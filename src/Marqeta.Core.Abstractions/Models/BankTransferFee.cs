using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BankTransferFee
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("bankTransfer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BankTransfer BankTransfer { get; set; }

        [JsonProperty("feeAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FeeAmount { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}