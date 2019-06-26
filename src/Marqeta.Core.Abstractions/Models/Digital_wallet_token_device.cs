using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token_device
    {
        [JsonProperty("device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_token_deviceDevice_type? Device_type { get; set; }

        [JsonProperty("device_lang_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(3)]
        public string Device_lang_code { get; set; }

        [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Device_id { get; set; }

        [JsonProperty("device_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Device_number { get; set; }

        [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Device_name { get; set; }

        [JsonProperty("device_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Device_location { get; set; }

        [JsonProperty("device_ip_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Device_ip_address { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}