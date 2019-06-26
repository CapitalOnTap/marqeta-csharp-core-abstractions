using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum PosTerminal_type
    {
        [EnumMember(Value = @"AUTO_DISPENSER_WITH_PIN")]
        AUTO_DISPENSER_WITH_PIN = 0,

        [EnumMember(Value = @"SELF_SERVICE")] SELF_SERVICE = 1,

        [EnumMember(Value = @"LIMITED_AMOUNT")]
        LIMITED_AMOUNT = 2,

        [EnumMember(Value = @"IN_FLIGHT")] IN_FLIGHT = 3,

        [EnumMember(Value = @"ECOMMERCE")] ECOMMERCE = 4,

        [EnumMember(Value = @"TRANSPONDER")] TRANSPONDER = 5
    }
}