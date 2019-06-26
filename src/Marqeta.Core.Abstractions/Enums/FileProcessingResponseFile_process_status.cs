using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum FileProcessingResponseFile_process_status
    {
        [EnumMember(Value = @"QUEUED")] QUEUED = 0,

        [EnumMember(Value = @"STARTED")] STARTED = 1,

        [EnumMember(Value = @"COMPLETED")] COMPLETED = 2,

        [EnumMember(Value = @"ERROR")] ERROR = 3,

        [EnumMember(Value = @"TERMINATED;")] TERMINATED = 4
    }
}