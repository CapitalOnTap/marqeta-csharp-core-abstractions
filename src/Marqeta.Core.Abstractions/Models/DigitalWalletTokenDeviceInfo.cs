using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DigitalWalletTokenDeviceInfo
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("digitalWalletToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletToken DigitalWalletToken { get; set; }

        [JsonProperty("deviceType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceType { get; set; }

        [JsonProperty("deviceLanguageCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceLanguageCode { get; set; }

        [JsonProperty("deviceSecureElementId", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceSecureElementId { get; set; }

        [JsonProperty("deviceNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceNumber { get; set; }

        [JsonProperty("deviceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }

        [JsonProperty("deviceLocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceLocation { get; set; }

        [JsonProperty("deviceIPAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceIPAddress { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}