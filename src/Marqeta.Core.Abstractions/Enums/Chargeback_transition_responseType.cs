using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_transition_responseType
    {
        [EnumMember(Value = @"initiated")] Initiated = 0,

        [EnumMember(Value = @"representment")] Representment = 1,

        [EnumMember(Value = @"prearbitration")]
        Prearbitration = 2,

        [EnumMember(Value = @"arbitration")] Arbitration = 3,

        [EnumMember(Value = @"case_won")] Case_won = 4,

        [EnumMember(Value = @"case_lost")] Case_lost = 5,

        [EnumMember(Value = @"network_rejected")]
        Network_rejected = 6,

        [EnumMember(Value = @"written_off_issuer")]
        Written_off_issuer = 7,

        [EnumMember(Value = @"written_off_program")]
        Written_off_program = 8
    }
}