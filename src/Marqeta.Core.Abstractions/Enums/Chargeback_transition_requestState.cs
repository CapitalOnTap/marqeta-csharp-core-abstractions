using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_transition_requestState
    {
        [EnumMember(Value = @"REPRESENTMENT")] REPRESENTMENT = 0,

        [EnumMember(Value = @"PREARBITRATION")]
        PREARBITRATION = 1,

        [EnumMember(Value = @"ARBITRATION")] ARBITRATION = 2,

        [EnumMember(Value = @"CASE_WON")] CASE_WON = 3,

        [EnumMember(Value = @"CASE_LOST")] CASE_LOST = 4,

        [EnumMember(Value = @"WRITTEN_OFF_ISSUER")]
        WRITTEN_OFF_ISSUER = 5,

        [EnumMember(Value = @"WRITTEN_OFF_PROGRAM")]
        WRITTEN_OFF_PROGRAM = 6
    }
}