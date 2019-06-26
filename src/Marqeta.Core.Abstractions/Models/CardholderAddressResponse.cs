using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CardholderAddressResponse
    {
        [JsonProperty("user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string User_token { get; set; }

        [JsonProperty("business_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Business_token { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("first_name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(40)]
        public string First_name { get; set; }

        [JsonProperty("last_name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(40)]
        public string Last_name { get; set; }

        [JsonProperty("address_1", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string Address_1 { get; set; }

        [JsonProperty("address_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Address_2 { get; set; }

        [JsonProperty("city", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(40)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(2)]
        public string State { get; set; }

        [JsonProperty("zip", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(10)]
        public string Zip { get; set; }

        [JsonProperty("postal_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(10)]
        public string Postal_code { get; set; }

        [JsonProperty("country", Required = Required.Always)]
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Country { get; set; }

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("is_default_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_default_address { get; set; } = false;

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}