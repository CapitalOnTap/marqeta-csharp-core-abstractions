using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class GLTransactionRequest
    {
        [JsonProperty("entries", Required = Required.Always)]
        [Required]
        public ICollection<GLEntry2> Entries { get; set; } = new Collection<GLEntry2>();

        [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        [JsonProperty("cardholder_visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cardholder_visible { get; set; } = true;

        [JsonProperty("reference_transaction_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Reference_transaction_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}