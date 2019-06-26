using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum PosTerminal_attendance
    {
        [EnumMember(Value = @"UNSPECIFIED")] UNSPECIFIED = 0,

        [EnumMember(Value = @"ATTENDED")] ATTENDED = 1,

        [EnumMember(Value = @"UNATTENDED")] UNATTENDED = 2,

        [EnumMember(Value = @"NO_TERMINAL")] NO_TERMINAL = 3
    }
}