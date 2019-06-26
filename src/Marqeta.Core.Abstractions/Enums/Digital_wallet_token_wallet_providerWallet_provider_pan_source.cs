using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Digital_wallet_token_wallet_providerWallet_provider_pan_source
    {
        [EnumMember(Value = @"ON_FILE")] ON_FILE = 0,

        [EnumMember(Value = @"KEY_ENTERED")] KEY_ENTERED = 1,

        [EnumMember(Value = @"MOBILE_BANKING_APP")]
        MOBILE_BANKING_APP = 2
    }
}