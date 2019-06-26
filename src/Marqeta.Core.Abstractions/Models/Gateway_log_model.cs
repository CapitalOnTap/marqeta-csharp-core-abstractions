using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Gateway_log_model
    {
        [JsonProperty("order_number", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Order_number { get; set; }

        [JsonProperty("transaction_id", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Transaction_id { get; set; }

        [JsonProperty("message", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Message { get; set; }

        [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("timed_out", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Timed_out { get; set; } = false;

        [JsonProperty("response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gateway_response Response { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}