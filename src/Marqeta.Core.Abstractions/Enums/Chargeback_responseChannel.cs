using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_responseChannel
    {
        [EnumMember(Value = @"GATEWAY")] GATEWAY = 0,

        [EnumMember(Value = @"GATEWAY_AUTOMATED")]
        GATEWAY_AUTOMATED = 1,

        [EnumMember(Value = @"ISSUER")] ISSUER = 2,

        [EnumMember(Value = @"ISSUER_AUTOMATED")]
        ISSUER_AUTOMATED = 3
    }
}