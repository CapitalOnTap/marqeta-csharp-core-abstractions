using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Clearing_record_request_modelCross_border_indicator
    {
        [EnumMember(Value = @"SINGLE_CURRENCY")]
        SINGLE_CURRENCY = 0,

        [EnumMember(Value = @"MULTI_CURRENCY")]
        MULTI_CURRENCY = 1,

        [EnumMember(Value = @"REBATE")] REBATE = 2,

        [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 3
    }
}