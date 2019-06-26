﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Config
    {
        [JsonProperty("authorization_controls", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Authorization_controls Authorization_controls { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}