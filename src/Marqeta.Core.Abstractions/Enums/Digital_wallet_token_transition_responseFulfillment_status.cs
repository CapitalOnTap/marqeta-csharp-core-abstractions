﻿using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Digital_wallet_token_transition_responseFulfillment_status
    {
        [EnumMember(Value = @"DECISION_RED")] DECISION_RED = 0,

        [EnumMember(Value = @"DECISION_YELLOW")]
        DECISION_YELLOW = 1,

        [EnumMember(Value = @"DECISION_GREEN")]
        DECISION_GREEN = 2,

        [EnumMember(Value = @"REJECTED")] REJECTED = 3,

        [EnumMember(Value = @"PROVISIONED")] PROVISIONED = 4
    }
}