using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum TransitTransaction_type
    {
        [EnumMember(Value = @"PRE_FUNDED")] PRE_FUNDED = 0,

        [EnumMember(Value = @"REAL_TIME_AUTHORIZED")]
        REAL_TIME_AUTHORIZED = 1,

        [EnumMember(Value = @"POST_AUTHORIZED_AGGREGATED")]
        POST_AUTHORIZED_AGGREGATED = 2,

        [EnumMember(Value = @"AUTHORIZED_AGGREGATED_SPLIT_CLEARING")]
        AUTHORIZED_AGGREGATED_SPLIT_CLEARING = 3,

        [EnumMember(Value = @"OTHER")] OTHER = 4,

        [EnumMember(Value = @"DEBIT_RECOVERY")]
        DEBIT_RECOVERY = 5
    }
}