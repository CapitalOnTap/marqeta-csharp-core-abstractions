using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum CardAttributeAttributeName
    {
        [EnumMember(Value = @"CARD_EXPEDITE")] CARD_EXPEDITE = 0,

        [EnumMember(Value = @"CARD_EXPIRATION_UNIT")]
        CARD_EXPIRATION_UNIT = 1,

        [EnumMember(Value = @"CARD_EXPIRATION_VALUE")]
        CARD_EXPIRATION_VALUE = 2,

        [EnumMember(Value = @"SUPER_INACTIVE")]
        SUPER_INACTIVE = 3,

        [EnumMember(Value = @"CARD_SET_OFFLINE_PIN_ON_NEXT_TRANSACTION")]
        CARD_SET_OFFLINE_PIN_ON_NEXT_TRANSACTION = 4,

        [EnumMember(Value = @"CARD_FULFILLMENT_REASON")]
        CARD_FULFILLMENT_REASON = 5
    }
}