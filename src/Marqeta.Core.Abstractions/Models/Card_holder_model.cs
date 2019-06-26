using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card_holder_model
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = true;

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Notes { get; set; }

        [JsonProperty("ip_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(39)]
        public string Ip_address { get; set; }

        [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Password { get; set; }

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Phone { get; set; }

        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Metadata { get; set; }

        [JsonProperty("account_holder_group_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36)]
        public string Account_holder_group_token { get; set; }

        [JsonProperty("identifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IdentificationRequestModel> Identifications { get; set; }

        [JsonProperty("honorific", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(10)]
        public string Honorific { get; set; }

        [JsonProperty("gender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(1)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Card_holder_modelGender? Gender { get; set; }

        [JsonProperty("first_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string First_name { get; set; }

        [JsonProperty("middle_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Middle_name { get; set; }

        [JsonProperty("last_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Last_name { get; set; }

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
        public string Email { get; set; }

        [JsonProperty("address1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Address1 { get; set; }

        [JsonProperty("address2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Address2 { get; set; }

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(2)]
        public string State { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Country { get; set; }

        [JsonProperty("birth_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Birth_date { get; set; }

        [JsonProperty("corporate_card_holder", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Corporate_card_holder { get; set; } = false;

        [JsonProperty("ssn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ssn { get; set; }

        [JsonProperty("passport_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Passport_number { get; set; }

        [JsonProperty("passport_expiration_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Passport_expiration_date { get; set; }

        [JsonProperty("id_card_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Id_card_number { get; set; }

        [JsonProperty("id_card_expiration_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Id_card_expiration_date { get; set; }

        [JsonProperty("nationality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Nationality { get; set; }

        [JsonProperty("company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Company { get; set; }

        [JsonProperty("parent_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Parent_token { get; set; }

        [JsonProperty("uses_parent_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Uses_parent_account { get; set; } = false;

        [JsonProperty("postal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(10)]
        public string Postal_code { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}