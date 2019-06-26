using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_transition_responseChannel
    {
        [EnumMember(Value = @"API")] API = 0,

        [EnumMember(Value = @"IVR")] IVR = 1,

        [EnumMember(Value = @"FRAUD")] FRAUD = 2,

        [EnumMember(Value = @"ADMIN")] ADMIN = 3,

        [EnumMember(Value = @"SYSTEM")] SYSTEM = 4
    }
}