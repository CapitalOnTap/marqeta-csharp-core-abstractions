using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum BusinessIncorporationRequestModelIncorporation_type
    {
        [EnumMember(Value = @"LLC")] LLC = 0,

        [EnumMember(Value = @"CORPORATION")] CORPORATION = 1,

        [EnumMember(Value = @"SOLE_PROPRIETORSHIP")]
        SOLE_PROPRIETORSHIP = 2,

        [EnumMember(Value = @"PARTNERSHIP")] PARTNERSHIP = 3,

        [EnumMember(Value = @"COOPERATIVE")] COOPERATIVE = 4,

        [EnumMember(Value = @"OTHER")] OTHER = 5
    }
}