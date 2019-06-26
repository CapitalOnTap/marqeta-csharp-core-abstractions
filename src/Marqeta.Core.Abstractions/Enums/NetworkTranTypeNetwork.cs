using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum NetworkTranTypeNetwork
    {
        [EnumMember(Value = @"MARQETA")] MARQETA = 0,

        [EnumMember(Value = @"GATEWAY_JIT")] GATEWAY_JIT = 1,

        [EnumMember(Value = @"MANAGED_JIT")] MANAGED_JIT = 2,

        [EnumMember(Value = @"DISCOVER")] DISCOVER = 3,

        [EnumMember(Value = @"MASTERCARD")] MASTERCARD = 4,

        [EnumMember(Value = @"MASTERCARDDEBIT")]
        MASTERCARDDEBIT = 5,

        [EnumMember(Value = @"MAESTRO")] MAESTRO = 6,

        [EnumMember(Value = @"CIRRUS")] CIRRUS = 7,

        [EnumMember(Value = @"PULSE")] PULSE = 8,

        [EnumMember(Value = @"VISA")] VISA = 9,

        [EnumMember(Value = @"VISAINTERLINK")] VISAINTERLINK = 10,

        [EnumMember(Value = @"VISAPLUS")] VISAPLUS = 11,

        [EnumMember(Value = @"VISANET")] VISANET = 12,

        [EnumMember(Value = @"VISANETDEBIT")] VISANETDEBIT = 13
    }
}