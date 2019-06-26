using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Terminal_model
    {
        [JsonProperty("tid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("partial_approval_capable", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Partial_approval_capable { get; set; }

        [JsonProperty("cardholder_presence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cardholder_presence { get; set; }

        [JsonProperty("card_presence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Card_presence { get; set; }

        [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        [JsonProperty("processing_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Processing_type { get; set; }

        [JsonProperty("pin_present", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pin_present { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}