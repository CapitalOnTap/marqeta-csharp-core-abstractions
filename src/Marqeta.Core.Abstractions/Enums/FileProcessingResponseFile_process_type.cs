using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum FileProcessingResponseFile_process_type
    {
        [EnumMember(Value = @"MASTERCARD_CLEARING")]
        MASTERCARD_CLEARING = 0,

        [EnumMember(Value = @"VISA_CLEARING")] VISA_CLEARING = 1,

        [EnumMember(Value = @"PULSE_CLEARING")]
        PULSE_CLEARING = 2,

        [EnumMember(Value = @"DISCOVER_CLEARING")]
        DISCOVER_CLEARING = 3
    }
}