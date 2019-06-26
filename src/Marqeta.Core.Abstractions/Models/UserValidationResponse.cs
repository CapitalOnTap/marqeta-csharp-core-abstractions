namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UserValidationResponse 
    {
        [Newtonsoft.Json.JsonProperty("birth_date", Required = Newtonsoft.Json.Required.Always)]
        public bool Birth_date { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Always)]
        public bool Phone { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.Always)]
        public bool Ssn { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}