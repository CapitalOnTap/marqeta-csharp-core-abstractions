using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Access_token_response
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("expires", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Expires { get; set; }

        [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Application Application { get; set; }

        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string User_token { get; set; }

        [JsonProperty("master_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Master_roles { get; set; }

        [JsonProperty("token_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token_type { get; set; }

        [JsonProperty("one_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? One_time { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}