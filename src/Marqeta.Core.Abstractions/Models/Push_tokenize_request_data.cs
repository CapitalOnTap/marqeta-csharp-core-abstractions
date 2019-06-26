using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Push_tokenize_request_data
    {
        [JsonProperty("display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Display_name { get; set; }

        [JsonProperty("last_digits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Last_digits { get; set; }

        [JsonProperty("network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Network { get; set; }

        [JsonProperty("token_service_provider", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Token_service_provider { get; set; }

        [JsonProperty("opaque_payment_card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Opaque_payment_card { get; set; }

        [JsonProperty("user_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AndroidPushTokenRequestAddress User_address { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}