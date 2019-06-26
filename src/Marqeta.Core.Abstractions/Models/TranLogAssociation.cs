using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class TranLogAssociation
    {
        [JsonProperty("tranLog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLog TranLog { get; set; }

        [JsonProperty("relatedTranLog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLog RelatedTranLog { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}