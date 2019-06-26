using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Jit_funding_programgateway_funding_sourceRefunds_destination
    {
        [EnumMember(Value = @"GATEWAY")] GATEWAY = 0,

        [EnumMember(Value = @"GPA")] GPA = 1,

        [EnumMember(Value = @"WATERFALL")] WATERFALL = 2
    }
}