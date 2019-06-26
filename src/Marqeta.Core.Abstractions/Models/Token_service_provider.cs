namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Token_service_provider 
    {
        [Newtonsoft.Json.JsonProperty("token_reference_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pan_reference_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Pan_reference_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("correlation_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Correlation_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_requestor_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_requestor_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_requestor_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_requestor_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_pan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_pan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_expiration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_expiration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_assurance_level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_assurance_level { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token_eligibility_decision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token_eligibility_decision { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}