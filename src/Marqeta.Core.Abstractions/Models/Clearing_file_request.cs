namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Clearing_file_request 
    {
        [Newtonsoft.Json.JsonProperty("transaction_tokens", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Clearing_record_request_model> Transaction_tokens { get; set; } = new System.Collections.ObjectModel.Collection<Clearing_record_request_model>();
    
        [Newtonsoft.Json.JsonProperty("wait_timeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Wait_timeout { get; set; }
    
        [Newtonsoft.Json.JsonProperty("batch_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Batch_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("clearing_folder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Clearing_folder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("encrypt_file", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Encrypt_file { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("create_completion_file", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Create_completion_file { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}