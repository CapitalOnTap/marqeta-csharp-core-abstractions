﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Response
    {
        [JsonProperty("code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Code { get; set; }

        [JsonProperty("memo", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Memo { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}