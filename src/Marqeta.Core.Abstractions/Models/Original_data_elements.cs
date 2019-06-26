using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Original_data_elements
    {
        [JsonProperty("mti", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Original_data_elementsMti? Mti { get; set; }

        [JsonProperty("stan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(12)]
        public string Stan { get; set; }

        [JsonProperty("transmission_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(14)]
        public string Transmission_time { get; set; }

        [JsonProperty("acquiring_institution_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(11)]
        public string Acquiring_institution_id { get; set; }

        [JsonProperty("network_reference_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(12)]
        public string Network_reference_id { get; set; }

        [JsonProperty("forwarding_institution_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(11)]
        public string Forwarding_institution_id { get; set; }

        [JsonProperty("transaction_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Transaction_token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}