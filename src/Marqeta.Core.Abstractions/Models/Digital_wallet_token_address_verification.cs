﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Digital_wallet_token_address_verification
    {
        [JsonProperty("validate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Validate { get; set; } = true;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}