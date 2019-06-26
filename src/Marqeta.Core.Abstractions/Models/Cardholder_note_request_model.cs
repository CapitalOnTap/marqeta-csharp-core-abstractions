using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Cardholder_note_request_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("description", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Description { get; set; }

        [JsonProperty("created_by", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Created_by { get; set; }

        [JsonProperty("created_by_user_role", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Cardholder_note_request_modelCreated_by_user_role? Created_by_user_role { get; set; }

        [JsonProperty("private", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}