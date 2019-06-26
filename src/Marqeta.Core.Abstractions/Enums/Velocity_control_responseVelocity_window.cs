using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Velocity_control_responseVelocity_window
    {
        [EnumMember(Value = @"DAY")] DAY = 0,

        [EnumMember(Value = @"WEEK")] WEEK = 1,

        [EnumMember(Value = @"MONTH")] MONTH = 2,

        [EnumMember(Value = @"LIFETIME")] LIFETIME = 3,

        [EnumMember(Value = @"TRANSACTION")] TRANSACTION = 4
    }
}