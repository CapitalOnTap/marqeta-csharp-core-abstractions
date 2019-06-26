using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Clearing_file_request
    {
        [JsonProperty("transaction_tokens", Required = Required.Always)]
        [Required]
        public ICollection<Clearing_record_request_model> Transaction_tokens { get; set; } =
            new Collection<Clearing_record_request_model>();

        [JsonProperty("wait_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Wait_timeout { get; set; }

        [JsonProperty("batch_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Batch_id { get; set; }

        [JsonProperty("clearing_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Clearing_folder { get; set; }

        [JsonProperty("encrypt_file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encrypt_file { get; set; } = false;

        [JsonProperty("create_completion_file", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_completion_file { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}