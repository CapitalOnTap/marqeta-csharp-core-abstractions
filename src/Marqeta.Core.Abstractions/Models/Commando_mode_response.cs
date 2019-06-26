﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Commando_mode_response
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("program_gateway_funding_source_token", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Program_gateway_funding_source_token { get; set; }

        [JsonProperty("current_state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Commando_mode_nested_transition Current_state { get; set; }

        [JsonProperty("commando_mode_enables", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Commando_mode_enables Commando_mode_enables { get; set; }

        [JsonProperty("real_time_standin_criteria", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Real_time_standin_criteria Real_time_standin_criteria { get; set; }

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}