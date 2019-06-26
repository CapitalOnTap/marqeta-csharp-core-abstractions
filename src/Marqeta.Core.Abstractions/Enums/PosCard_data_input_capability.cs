using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum PosCard_data_input_capability
    {
        [EnumMember(Value = @"NO_TERMINAL")] NO_TERMINAL = 0,

        [EnumMember(Value = @"MAG_STRIPE")] MAG_STRIPE = 1,

        [EnumMember(Value = @"MAG_STRIPE_CONTACTLESS")]
        MAG_STRIPE_CONTACTLESS = 2,

        [EnumMember(Value = @"MAG_STRIPE_KEY_ENTRY")]
        MAG_STRIPE_KEY_ENTRY = 3,

        [EnumMember(Value = @"CHIP")] CHIP = 4,

        [EnumMember(Value = @"CHIP_CONTACTLESS")]
        CHIP_CONTACTLESS = 5,

        [EnumMember(Value = @"CHIP_MAG_STRIPE")]
        CHIP_MAG_STRIPE = 6,

        [EnumMember(Value = @"CHIP_MAG_STRIPE_KEY_ENTRY")]
        CHIP_MAG_STRIPE_KEY_ENTRY = 7,

        [EnumMember(Value = @"KEY_ENTRY")] KEY_ENTRY = 8,

        [EnumMember(Value = @"OCR")] OCR = 9,

        [EnumMember(Value = @"MICR")] MICR = 10
    }
}