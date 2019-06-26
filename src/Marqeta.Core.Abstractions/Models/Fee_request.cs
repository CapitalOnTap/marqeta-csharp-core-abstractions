﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Fee_request
    {
        [JsonProperty("name", Required = Required.Always)]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
        public string Tags { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("currency_code", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Currency_code { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = true;

        [JsonProperty("real_time_assessment", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public RealTimeFeeAssessmentRequest Real_time_assessment { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}