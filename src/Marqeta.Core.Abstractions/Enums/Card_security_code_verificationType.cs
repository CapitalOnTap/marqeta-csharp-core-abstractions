using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_security_code_verificationType
    {
        [EnumMember(Value = @"CVV1")] CVV1 = 0,

        [EnumMember(Value = @"CVV2")] CVV2 = 1,

        [EnumMember(Value = @"ICVV")] ICVV = 2
    }
}