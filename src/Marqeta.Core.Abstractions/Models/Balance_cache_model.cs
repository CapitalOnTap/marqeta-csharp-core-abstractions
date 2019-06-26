using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Balance_cache_model
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("account", Required = Required.Always)]
        [Required]
        public Account_model Account { get; set; } = new Account_model();

        [JsonProperty("balance", Required = Required.Always)]
        public double Balance { get; set; }

        [JsonProperty("layers", Required = Required.Always)]
        [Required]
        public ICollection<int> Layers { get; set; } = new Collection<int>();

        [JsonProperty("user_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string User_token { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}