using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_responseNetwork
    {
        [EnumMember(Value = @"MARQETA")] MARQETA = 0,

        [EnumMember(Value = @"DISCOVER")] DISCOVER = 1,

        [EnumMember(Value = @"MASTERCARD")] MASTERCARD = 2,

        [EnumMember(Value = @"PULSE")] PULSE = 3,

        [EnumMember(Value = @"VISA")] VISA = 4
    }
}