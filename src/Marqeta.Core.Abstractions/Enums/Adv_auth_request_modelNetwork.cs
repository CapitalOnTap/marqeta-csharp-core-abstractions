using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Adv_auth_request_modelNetwork
    {
        [EnumMember(Value = @"MASTERCARD")] MASTERCARD = 0,

        [EnumMember(Value = @"DISCOVER")] DISCOVER = 1,

        [EnumMember(Value = @"PULSE")] PULSE = 2,

        [EnumMember(Value = @"VISA")] VISA = 3
    }
}