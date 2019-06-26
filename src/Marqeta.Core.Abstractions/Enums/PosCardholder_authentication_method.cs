using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum PosCardholder_authentication_method
    {
        [EnumMember(Value = @"UNSPECIFIED")] UNSPECIFIED = 0,

        [EnumMember(Value = @"NON_AUTHENTICATED")]
        NON_AUTHENTICATED = 1,

        [EnumMember(Value = @"SIGNATURE")] SIGNATURE = 2,

        [EnumMember(Value = @"PIN")] PIN = 3,

        [EnumMember(Value = @"ID_VERIFIED")] ID_VERIFIED = 4
    }
}