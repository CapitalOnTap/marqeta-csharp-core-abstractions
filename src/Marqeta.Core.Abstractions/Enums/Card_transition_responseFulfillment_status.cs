using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_transition_responseFulfillment_status
    {
        [EnumMember(Value = @"ISSUED")] ISSUED = 0,

        [EnumMember(Value = @"ORDERED")] ORDERED = 1,

        [EnumMember(Value = @"REJECTED")] REJECTED = 2,

        [EnumMember(Value = @"SHIPPED")] SHIPPED = 3,

        [EnumMember(Value = @"DELIVERED")] DELIVERED = 4,

        [EnumMember(Value = @"DIGITALLY_PRESENTED")]
        DIGITALLY_PRESENTED = 5
    }
}