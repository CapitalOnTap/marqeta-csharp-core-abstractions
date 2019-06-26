using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum BulkCardOrderExpirationOffsetUnit
    {
        [EnumMember(Value = @"YEARS")] YEARS = 0,

        [EnumMember(Value = @"MONTHS")] MONTHS = 1,

        [EnumMember(Value = @"DAYS")] DAYS = 2,

        [EnumMember(Value = @"HOURS")] HOURS = 3,

        [EnumMember(Value = @"MINUTES")] MINUTES = 4,

        [EnumMember(Value = @"SECONDS")] SECONDS = 5
    }
}