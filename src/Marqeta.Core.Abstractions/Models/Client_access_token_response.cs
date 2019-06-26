using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Client_access_token_response
    {
        [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Application Application { get; set; }

        [JsonProperty("created", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("expires", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Expires { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("card_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Card_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}