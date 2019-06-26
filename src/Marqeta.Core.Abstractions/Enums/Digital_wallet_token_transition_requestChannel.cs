using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Digital_wallet_token_transition_requestChannel
    {
        [EnumMember(Value = @"TOKEN_SERVICE_PROVIDER")]
        TOKEN_SERVICE_PROVIDER = 0,

        [EnumMember(Value = @"TOKEN_SERVICE_PROVIDER_API")]
        TOKEN_SERVICE_PROVIDER_API = 1,

        [EnumMember(Value = @"DIGITAL_WALLET")]
        DIGITAL_WALLET = 2,

        [EnumMember(Value = @"API")] API = 3,

        [EnumMember(Value = @"IVR")] IVR = 4,

        [EnumMember(Value = @"FRAUD")] FRAUD = 5,

        [EnumMember(Value = @"ADMIN")] ADMIN = 6,

        [EnumMember(Value = @"SYSTEM")] SYSTEM = 7
    }
}