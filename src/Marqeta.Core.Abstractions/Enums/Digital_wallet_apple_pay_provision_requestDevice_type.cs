using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Digital_wallet_apple_pay_provision_requestDevice_type
    {
        [EnumMember(Value = @"MOBILE_PHONE")] MOBILE_PHONE = 0,

        [EnumMember(Value = @"WATCH")] WATCH = 1,

        [EnumMember(Value = @"TABLET")] TABLET = 2
    }
}