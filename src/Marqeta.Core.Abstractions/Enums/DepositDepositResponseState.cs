using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum DepositDepositResponseState
    {
        [EnumMember(Value = @"PENDING")] PENDING = 0,

        [EnumMember(Value = @"APPLIED")] APPLIED = 1,

        [EnumMember(Value = @"REVERSED")] REVERSED = 2,

        [EnumMember(Value = @"REJECTED")] REJECTED = 3
    }
}