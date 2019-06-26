using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Bank_transfer_transition_request_modelStatus
    {
        [EnumMember(Value = @"PENDING")] PENDING = 0,

        [EnumMember(Value = @"PROCESSING")] PROCESSING = 1,

        [EnumMember(Value = @"SUBMITTED")] SUBMITTED = 2,

        [EnumMember(Value = @"RETURNED")] RETURNED = 3,

        [EnumMember(Value = @"COMPLETED")] COMPLETED = 4,

        [EnumMember(Value = @"CANCELED")] CANCELED = 5
    }
}