using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_responseState
    {
        [EnumMember(Value = @"UNACTIVATED")] UNACTIVATED = 0,

        [EnumMember(Value = @"ACTIVE")] ACTIVE = 1,

        [EnumMember(Value = @"SUSPENDED")] SUSPENDED = 2,

        [EnumMember(Value = @"TERMINATED")] TERMINATED = 3,

        [EnumMember(Value = @"UNSUPPORTED")] UNSUPPORTED = 4
    }
}