﻿namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Accepted_countries_model 
    {
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("is_whitelist", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_whitelist { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("country_codes", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> Country_codes { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        [Newtonsoft.Json.JsonProperty("created_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Created_time { get; set; }
    
        [Newtonsoft.Json.JsonProperty("last_modified_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Last_modified_time { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}