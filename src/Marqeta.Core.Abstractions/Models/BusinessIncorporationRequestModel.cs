using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BusinessIncorporationRequestModel
    {
        [JsonProperty("is_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_public { get; set; } = false;

        [JsonProperty("stock_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Stock_symbol { get; set; }

        [JsonProperty("state_of_incorporation", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string State_of_incorporation { get; set; }

        [JsonProperty("name_registered_under", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Name_registered_under { get; set; }

        [JsonProperty("address_registered_under", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressRequestModel Address_registered_under { get; set; }

        [JsonProperty("incorporation_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        [JsonConverter(typeof(StringEnumConverter))]
        public BusinessIncorporationRequestModelIncorporation_type? Incorporation_type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}