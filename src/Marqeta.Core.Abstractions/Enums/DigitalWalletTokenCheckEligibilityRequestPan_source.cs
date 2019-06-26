using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum DigitalWalletTokenCheckEligibilityRequestPan_source
    {
        [EnumMember(Value = @"KEY_ENTERED")] KEY_ENTERED = 0,

        [EnumMember(Value = @"ON_FILE")] ON_FILE = 1,

        [EnumMember(Value = @"MOBILE_BANKING_APP")]
        MOBILE_BANKING_APP = 2
    }
}