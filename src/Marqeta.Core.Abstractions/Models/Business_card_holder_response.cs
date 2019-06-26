using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Business_card_holder_response
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Notes { get; set; }

        [JsonProperty("ip_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(39)]
        public string Ip_address { get; set; }

        [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
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

        [JsonProperty("authentication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Authentication Authentication { get; set; }

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Business_card_holder_responseStatus? Status { get; set; }

        [JsonProperty("business_name_legal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Business_name_legal { get; set; }

        [JsonProperty("business_name_dba", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Business_name_dba { get; set; }

        [JsonProperty("office_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressResponseModel Office_location { get; set; }

        [JsonProperty("in_current_location_since", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? In_current_location_since { get; set; }

        [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Website { get; set; }

        [JsonProperty("date_established", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_established { get; set; }

        [JsonProperty("general_business_description", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string General_business_description { get; set; }

        [JsonProperty("history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string History { get; set; }

        [JsonProperty("business_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Business_type { get; set; }

        [JsonProperty("international_office_locations", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string International_office_locations { get; set; }

        [JsonProperty("taxpayer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Taxpayer_id { get; set; }

        [JsonProperty("duns_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Duns_number { get; set; }

        [JsonProperty("primary_contact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PrimaryContactInfoModel Primary_contact { get; set; }

        [JsonProperty("incorporation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessIncorporationResponseModel Incorporation { get; set; }

        [JsonProperty("proprietor_or_officer", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public BusinessProprietorResponseModel Proprietor_or_officer { get; set; }

        [JsonProperty("identifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IdentificationResponseModel> Identifications { get; set; }

        [JsonProperty("deposit_account", Required = Required.Always)]
        [Required]
        public Deposit_account Deposit_account { get; set; } = new Deposit_account();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}