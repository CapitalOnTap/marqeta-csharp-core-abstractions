using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Transaction_modelPolarity
    {
        [EnumMember(Value = @"CREDIT")] CREDIT = 0,

        [EnumMember(Value = @"DEBIT")] DEBIT = 1,

        [EnumMember(Value = @"PENDING_CREDIT")]
        PENDING_CREDIT = 2,

        [EnumMember(Value = @"PENDING_DEBIT")] PENDING_DEBIT = 3
    }
}