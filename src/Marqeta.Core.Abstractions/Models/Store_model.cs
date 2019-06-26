using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Store_model
    {
        [JsonProperty("name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(40)]
        public string Name { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = true;

        [JsonProperty("contact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Contact { get; set; }

        [JsonProperty("contact_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Contact_email { get; set; }

        [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [JsonProperty("address1", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string Address1 { get; set; }

        [JsonProperty("address2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Address2 { get; set; }

        [JsonProperty("city", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(40)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string State { get; set; }

        [JsonProperty("province", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string Province { get; set; }

        [JsonProperty("zip", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(10)]
        public string Zip { get; set; }

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Country { get; set; }

        /// <summary>The unique identifier of the merchant.</summary>
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("partial_auth_flag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partial_auth_flag { get; set; } = true;

        [JsonProperty("mid", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Mid { get; set; }

        [JsonProperty("network_mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50, MinimumLength = 1)]
        public string Network_mid { get; set; }

        [JsonProperty("merchant_token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(36)]
        public string Merchant_token { get; set; }

        [JsonProperty("partial_approval_capable", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partial_approval_capable { get; set; } = false;

        [JsonProperty("keyed_auth_cvv_enforced", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Keyed_auth_cvv_enforced { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}