using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class AddressResponseModel
    {
        [JsonProperty("address1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(35)]
        public string Address1 { get; set; }

        [JsonProperty("address2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(35)]
        public string Address2 { get; set; }

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(35)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(35)]
        public string State { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string Zip { get; set; }

        [JsonProperty("postal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string Postal_code { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Country { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}