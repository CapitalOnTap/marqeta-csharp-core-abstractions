using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum UserCardHolderSsnType
    {
        [EnumMember(Value = @"SSN")] SSN = 0,

        [EnumMember(Value = @"TIN")] TIN = 1,

        [EnumMember(Value = @"SIN")] SIN = 2,

        [EnumMember(Value = @"NIN")] NIN = 3,

        [EnumMember(Value = @"PASSPORT_NUMBER")]
        PASSPORT_NUMBER = 4,

        [EnumMember(Value = @"DRIVERS_LICENSE")]
        DRIVERS_LICENSE = 5,

        [EnumMember(Value = @"BUSINESS_NUMBER")]
        BUSINESS_NUMBER = 6,

        [EnumMember(Value = @"BUSINESS_TAX_ID")]
        BUSINESS_TAX_ID = 7,

        [EnumMember(Value = @"TAXPAYER_REFERENCE")]
        TAXPAYER_REFERENCE = 8
    }
}