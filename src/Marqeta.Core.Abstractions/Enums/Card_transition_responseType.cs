using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_transition_responseType
    {
        [EnumMember(Value = @"fulfillment_issued")]
        Fulfillment_issued = 0,

        [EnumMember(Value = @"state_activated")]
        State_activated = 1,

        [EnumMember(Value = @"state_suspended")]
        State_suspended = 2,

        [EnumMember(Value = @"state_reinstated")]
        State_reinstated = 3,

        [EnumMember(Value = @"state_terminated")]
        State_terminated = 4,

        [EnumMember(Value = @"fulfillment_ordered")]
        Fulfillment_ordered = 5,

        [EnumMember(Value = @"fulfillment_rejected")]
        Fulfillment_rejected = 6,

        [EnumMember(Value = @"fulfillment_shipped")]
        Fulfillment_shipped = 7,

        [EnumMember(Value = @"fulfillment_delivered")]
        Fulfillment_delivered = 8,

        [EnumMember(Value = @"fulfillment_digitally_presented")]
        Fulfillment_digitally_presented = 9
    }
}