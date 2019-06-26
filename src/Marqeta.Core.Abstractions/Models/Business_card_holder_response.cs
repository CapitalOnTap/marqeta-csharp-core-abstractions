namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Business_card_holder_response 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Notes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ip_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(39)]
        public string Ip_address { get; set; }
    
        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255, MinimumLength = 1)]
        public string Password { get; set; }
    
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Phone { get; set; }
    
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account_holder_group_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string Account_holder_group_token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("authentication", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Authentication Authentication { get; set; }
    
        [Newtonsoft.Json.JsonProperty("created_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Created_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("last_modified_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Last_modified_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Business_card_holder_responseStatus? Status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("business_name_legal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Business_name_legal { get; set; }
    
        [Newtonsoft.Json.JsonProperty("business_name_dba", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Business_name_dba { get; set; }
    
        [Newtonsoft.Json.JsonProperty("office_location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressResponseModel Office_location { get; set; }
    
        [Newtonsoft.Json.JsonProperty("in_current_location_since", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? In_current_location_since { get; set; }
    
        [Newtonsoft.Json.JsonProperty("website", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Website { get; set; }
    
        [Newtonsoft.Json.JsonProperty("date_established", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date_established { get; set; }
    
        [Newtonsoft.Json.JsonProperty("general_business_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string General_business_description { get; set; }
    
        [Newtonsoft.Json.JsonProperty("history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string History { get; set; }
    
        [Newtonsoft.Json.JsonProperty("business_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Business_type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("international_office_locations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string International_office_locations { get; set; }
    
        [Newtonsoft.Json.JsonProperty("taxpayer_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Taxpayer_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("duns_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Duns_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("primary_contact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PrimaryContactInfoModel Primary_contact { get; set; }
    
        [Newtonsoft.Json.JsonProperty("incorporation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BusinessIncorporationResponseModel Incorporation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("proprietor_or_officer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BusinessProprietorResponseModel Proprietor_or_officer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("identifications", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<IdentificationResponseModel> Identifications { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deposit_account", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Deposit_account Deposit_account { get; set; } = new Deposit_account();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}