﻿using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Bank_transfer_transition_request_modelChannel
    {
        [EnumMember(Value = @"API")] API = 0,

        [EnumMember(Value = @"SYSTEM")] SYSTEM = 1
    }
}