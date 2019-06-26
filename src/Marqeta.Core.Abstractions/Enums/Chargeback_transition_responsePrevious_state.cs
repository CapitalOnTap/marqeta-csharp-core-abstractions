using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_transition_responsePrevious_state
    {
        [EnumMember(Value = @"INITIATED")] INITIATED = 0,

        [EnumMember(Value = @"REPRESENTMENT")] REPRESENTMENT = 1,

        [EnumMember(Value = @"PREARBITRATION")]
        PREARBITRATION = 2,

        [EnumMember(Value = @"ARBITRATION")] ARBITRATION = 3,

        [EnumMember(Value = @"CASE_WON")] CASE_WON = 4,

        [EnumMember(Value = @"CASE_LOST")] CASE_LOST = 5,

        [EnumMember(Value = @"NETWORK_REJECTED")]
        NETWORK_REJECTED = 6
    }
}