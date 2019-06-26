using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum PosPan_entry_mode
    {
        [EnumMember(Value = @"MANUAL")] MANUAL = 0,

        [EnumMember(Value = @"MAG_STRIPE")] MAG_STRIPE = 1,

        [EnumMember(Value = @"MAG_STRIPE_CONTACTLESS")]
        MAG_STRIPE_CONTACTLESS = 2,

        [EnumMember(Value = @"BAR_CODE")] BAR_CODE = 3,

        [EnumMember(Value = @"OCR")] OCR = 4,

        [EnumMember(Value = @"MICR")] MICR = 5,

        [EnumMember(Value = @"CHIP")] CHIP = 6,

        [EnumMember(Value = @"CHIP_CONTACTLESS")]
        CHIP_CONTACTLESS = 7,

        [EnumMember(Value = @"CHIP_FALLBACK")] CHIP_FALLBACK = 8,

        [EnumMember(Value = @"OTHER")] OTHER = 9
    }
}