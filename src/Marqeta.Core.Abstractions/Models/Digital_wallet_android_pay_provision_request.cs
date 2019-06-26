using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_android_pay_provision_request
    {
        [JsonProperty("card_token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Card_token { get; set; }

        [JsonProperty("device_type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Digital_wallet_android_pay_provision_requestDevice_type Device_type { get; set; }

        [JsonProperty("provisioning_app_version", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Provisioning_app_version { get; set; }

        [JsonProperty("wallet_account_id", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Wallet_account_id { get; set; }

        [JsonProperty("device_id", Required = Required.Always)]
        [Required]
        [StringLength(24, MinimumLength = 1)]
        public string Device_id { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}