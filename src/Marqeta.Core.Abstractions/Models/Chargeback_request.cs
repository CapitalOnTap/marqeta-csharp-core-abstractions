using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Chargeback_request
    {
        [JsonProperty("reason_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Chargeback_requestReason_description? Reason_description { get; set; }

        [JsonProperty("reason_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Reason_code { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("transaction_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Transaction_token { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        [Range(0, int.MaxValue)]
        public double Amount { get; set; }

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(1024, MinimumLength = 1)]
        public string Memo { get; set; }

        [JsonProperty("credit_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Credit_user { get; set; } = true;

        [JsonProperty("channel", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Chargeback_requestChannel Channel { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}