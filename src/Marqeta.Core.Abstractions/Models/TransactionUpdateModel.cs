﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class TransactionUpdateModel
    {
        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionUpdateModelState? State { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}