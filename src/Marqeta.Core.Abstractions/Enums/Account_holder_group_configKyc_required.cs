using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Account_holder_group_configKyc_required
    {
        [EnumMember(Value = @"ALWAYS")] ALWAYS = 0,

        [EnumMember(Value = @"CONDITIONAL")] CONDITIONAL = 1,

        [EnumMember(Value = @"NEVER")] NEVER = 2
    }
}