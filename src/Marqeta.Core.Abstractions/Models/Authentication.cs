using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Authentication
    {
        [JsonProperty("last_password_update_channel", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public AuthenticationLast_password_update_channel? Last_password_update_channel { get; set; }

        [JsonProperty("last_password_update_time", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_password_update_time { get; set; }

        [JsonProperty("email_verified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Email_verified { get; set; } = false;

        [JsonProperty("email_verified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Email_verified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}