namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Jit_funding 
    {
        [Newtonsoft.Json.JsonProperty("paymentcard_funding_source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Jit_funding_paymentcard_funding_source Paymentcard_funding_source { get; set; }
    
        [Newtonsoft.Json.JsonProperty("programgateway_funding_source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Jit_funding_programgateway_funding_source Programgateway_funding_source { get; set; }
    
        [Newtonsoft.Json.JsonProperty("program_funding_source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Jit_funding_program_funding_source Program_funding_source { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}