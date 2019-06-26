using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum TransactionUpdateModelState
    {
        [EnumMember(Value = @"PENDING")] PENDING = 0,

        [EnumMember(Value = @"CLEARED")] CLEARED = 1,

        [EnumMember(Value = @"COMPLETION")] COMPLETION = 2,

        [EnumMember(Value = @"DECLINED")] DECLINED = 3,

        [EnumMember(Value = @"ERROR")] ERROR = 4,

        [EnumMember(Value = @"ALL")] ALL = 5
    }
}