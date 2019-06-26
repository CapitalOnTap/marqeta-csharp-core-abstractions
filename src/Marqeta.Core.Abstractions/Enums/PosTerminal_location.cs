using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum PosTerminal_location
    {
        [EnumMember(Value = @"ON_PREMISE")] ON_PREMISE = 0,

        [EnumMember(Value = @"OFF_PREMISE_MERCHANT")]
        OFF_PREMISE_MERCHANT = 1,

        [EnumMember(Value = @"OFF_PREMISE_CARDHOLDER")]
        OFF_PREMISE_CARDHOLDER = 2,

        [EnumMember(Value = @"NO_TERMINAL")] NO_TERMINAL = 3
    }
}