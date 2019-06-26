using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Peer_transfer_response
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

        [JsonProperty("currency_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }

        [JsonProperty("sender_user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Sender_user_token { get; set; }

        [JsonProperty("recipient_user_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Recipient_user_token { get; set; }

        [JsonProperty("sender_business_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Sender_business_token { get; set; }

        [JsonProperty("recipient_business_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Recipient_business_token { get; set; }

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}