﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BillingAddress
    {
        [JsonProperty("first_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string First_name { get; set; }

        [JsonProperty("last_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Last_name { get; set; }

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}