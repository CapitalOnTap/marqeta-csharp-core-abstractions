using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum RealTimeFeeAssessmentRequestTransaction_type
    {
        [EnumMember(Value = @"authorization")] Authorization = 0,

        [EnumMember(Value = @"pindebit_atm_withdrawal")]
        Pindebit_atm_withdrawal = 1,

        [EnumMember(Value = @"pindebit")] Pindebit = 2
    }
}