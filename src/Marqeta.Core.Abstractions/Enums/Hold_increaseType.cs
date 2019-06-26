using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Hold_increaseType
    {
        [EnumMember(Value = @"AMOUNT")] AMOUNT = 0,

        [EnumMember(Value = @"PERCENT")] PERCENT = 1,

        [EnumMember(Value = @"UP_TO_LIMIT")] UP_TO_LIMIT = 2
    }
}