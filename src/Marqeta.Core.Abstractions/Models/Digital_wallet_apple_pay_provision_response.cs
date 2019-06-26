using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_apple_pay_provision_response
    {
        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("card_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Card_token { get; set; }

        [JsonProperty("encrypted_pass_data", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Encrypted_pass_data { get; set; }

        [JsonProperty("activation_data", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Activation_data { get; set; }

        [JsonProperty("ephemeral_public_key", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Ephemeral_public_key { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}