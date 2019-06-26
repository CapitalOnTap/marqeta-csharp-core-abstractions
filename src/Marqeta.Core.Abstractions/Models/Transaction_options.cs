using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Transaction_options
    {
        [JsonProperty("additional_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Additional_data { get; set; }

        [JsonProperty("database_transaction_timeout", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Database_transaction_timeout { get; set; }

        [JsonProperty("pre_auth_time_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pre_auth_time_limit { get; set; }

        [JsonProperty("send_expiration_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_expiration_date { get; set; } = true;

        [JsonProperty("send_track_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_track_data { get; set; } = true;

        [JsonProperty("card_expiration_date_yymm", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Card_expiration_date_yymm { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}