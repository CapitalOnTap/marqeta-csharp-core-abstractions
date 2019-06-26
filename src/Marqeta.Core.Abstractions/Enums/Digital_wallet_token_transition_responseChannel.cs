using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Digital_wallet_token_transition_responseChannel
    {
        [EnumMember(Value = @"TOKEN_SERVICE_PROVIDER")]
        TOKEN_SERVICE_PROVIDER = 0,

        [EnumMember(Value = @"DIGITAL_WALLET")]
        DIGITAL_WALLET = 1,

        [EnumMember(Value = @"API")] API = 2,

        [EnumMember(Value = @"IVR")] IVR = 3,

        [EnumMember(Value = @"FRAUD")] FRAUD = 4,

        [EnumMember(Value = @"ADMIN")] ADMIN = 5,

        [EnumMember(Value = @"SYSTEM")] SYSTEM = 6
    }
}