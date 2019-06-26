using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_transition_requestState
    {
        [EnumMember(Value = @"ACTIVE")] ACTIVE = 0,

        [EnumMember(Value = @"SUSPENDED")] SUSPENDED = 1,

        [EnumMember(Value = @"TERMINATED")] TERMINATED = 2
    }
}