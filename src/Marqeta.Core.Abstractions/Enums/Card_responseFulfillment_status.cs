using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_responseFulfillment_status
    {
        [EnumMember(Value = @"ISSUED")] ISSUED = 0,

        [EnumMember(Value = @"ORDERED")] ORDERED = 1,

        [EnumMember(Value = @"REORDERED")] REORDERED = 2,

        [EnumMember(Value = @"REJECTED")] REJECTED = 3,

        [EnumMember(Value = @"SHIPPED")] SHIPPED = 4,

        [EnumMember(Value = @"DELIVERED")] DELIVERED = 5,

        [EnumMember(Value = @"DIGITALLY_PRESENTED")]
        DIGITALLY_PRESENTED = 6
    }
}