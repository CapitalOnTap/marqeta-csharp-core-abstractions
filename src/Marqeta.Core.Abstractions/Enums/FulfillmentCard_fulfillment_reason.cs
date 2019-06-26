using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum FulfillmentCard_fulfillment_reason
    {
        [EnumMember(Value = @"NEW")] NEW = 0,

        [EnumMember(Value = @"LOST_STOLEN")] LOST_STOLEN = 1,

        [EnumMember(Value = @"EXPIRED")] EXPIRED = 2
    }
}