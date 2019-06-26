using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Business_card_holder_responseStatus
    {
        [EnumMember(Value = @"UNVERIFIED")] UNVERIFIED = 0,

        [EnumMember(Value = @"LIMITED")] LIMITED = 1,

        [EnumMember(Value = @"ACTIVE")] ACTIVE = 2,

        [EnumMember(Value = @"SUSPENDED")] SUSPENDED = 3,

        [EnumMember(Value = @"CLOSED")] CLOSED = 4
    }
}