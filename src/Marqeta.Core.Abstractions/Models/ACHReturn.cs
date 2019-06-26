using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ACHReturn
    {
        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("dateInitiated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateInitiated { get; set; }

        [JsonProperty("orderId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        [JsonProperty("reasonCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        [JsonProperty("directDeposit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DirectDeposit { get; set; } = false;

        [JsonProperty("achType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AchType { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}