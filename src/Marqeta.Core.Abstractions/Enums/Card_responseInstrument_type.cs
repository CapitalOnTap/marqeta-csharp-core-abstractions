using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_responseInstrument_type
    {
        [EnumMember(Value = @"PHYSICAL_MSR")] PHYSICAL_MSR = 0,

        [EnumMember(Value = @"PHYSICAL_ICC")] PHYSICAL_ICC = 1,

        [EnumMember(Value = @"PHYSICAL_CONTACTLESS")]
        PHYSICAL_CONTACTLESS = 2,

        [EnumMember(Value = @"PHYSICAL_COMBO")]
        PHYSICAL_COMBO = 3,

        [EnumMember(Value = @"VIRTUAL_PAN")] VIRTUAL_PAN = 4
    }
}