using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum DigitalWalletTokenTokenState
    {
        [EnumMember(Value = @"REQUESTED")] REQUESTED = 0,

        [EnumMember(Value = @"ACTIVE")] ACTIVE = 1,

        [EnumMember(Value = @"TERMINATED")] TERMINATED = 2,

        [EnumMember(Value = @"SUSPENDED")] SUSPENDED = 3,

        [EnumMember(Value = @"REQUEST_DECLINED")]
        REQUEST_DECLINED = 4
    }
}