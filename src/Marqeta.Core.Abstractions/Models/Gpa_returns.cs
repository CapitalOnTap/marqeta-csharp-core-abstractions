using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Gpa_returns
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("transaction_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Transaction_token { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string State { get; set; }

        [JsonProperty("response", Required = Required.Always)]
        [Required]
        public Response Response { get; set; } = new Response();

        [JsonProperty("funding", Required = Required.Always)]
        [Required]
        public Funding Funding { get; set; } = new Funding();

        [JsonProperty("funding_source_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Funding_source_token { get; set; }

        [JsonProperty("funding_source_address_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Funding_source_address_token { get; set; }

        [JsonProperty("original_order_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Original_order_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}