using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ClearingRetryModel
    {
        [JsonProperty("original_failed_transaction_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Original_failed_transaction_token { get; set; }

        [JsonProperty("new_network_reference", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string New_network_reference { get; set; }

        [JsonProperty("new_approval_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string New_approval_code { get; set; }

        [JsonProperty("new_stan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string New_stan { get; set; }

        [JsonProperty("find_original_window_days", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Find_original_window_days { get; set; }

        [JsonProperty("new_processing_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string New_processing_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}