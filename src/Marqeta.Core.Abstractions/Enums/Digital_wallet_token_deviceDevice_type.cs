using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Digital_wallet_token_deviceDevice_type
    {
        [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 0,

        [EnumMember(Value = @"MOBILE_PHONE")] MOBILE_PHONE = 1,

        [EnumMember(Value = @"WATCH")] WATCH = 2,

        [EnumMember(Value = @"TABLET")] TABLET = 3,

        [EnumMember(Value = @"MOBILE_PHONE_OR_TABLET")]
        MOBILE_PHONE_OR_TABLET = 4,

        [EnumMember(Value = @"PERSONAL_COMPUTER")]
        PERSONAL_COMPUTER = 5
    }
}