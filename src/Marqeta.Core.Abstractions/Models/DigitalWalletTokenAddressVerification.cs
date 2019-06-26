using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DigitalWalletTokenAddressVerification
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("digitalWalletToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletToken DigitalWalletToken { get; set; }

        [JsonProperty("avsZip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AvsZip { get; set; }

        [JsonProperty("avsCardholderName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AvsCardholderName { get; set; }

        [JsonProperty("avsStreetAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AvsStreetAddress { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}