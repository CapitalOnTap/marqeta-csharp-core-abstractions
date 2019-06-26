using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Transaction_metadataTransaction_category
    {
        [EnumMember(Value = @"RETAIL_SALE")] RETAIL_SALE = 0,

        [EnumMember(Value = @"BILL_PAY")] BILL_PAY = 1,

        [EnumMember(Value = @"HOTEL")] HOTEL = 2,

        [EnumMember(Value = @"HEALTH_CARE")] HEALTH_CARE = 3,

        [EnumMember(Value = @"RESTAURANT")] RESTAURANT = 4,

        [EnumMember(Value = @"AUTO_RENTAL")] AUTO_RENTAL = 5,

        [EnumMember(Value = @"AIRLINE")] AIRLINE = 6,

        [EnumMember(Value = @"PAYMENT")] PAYMENT = 7,

        [EnumMember(Value = @"HOSPITALIZATION_COLLEGE")]
        HOSPITALIZATION_COLLEGE = 8,

        [EnumMember(Value = @"PHONE_MAIL_ECOMMERCE")]
        PHONE_MAIL_ECOMMERCE = 9,

        [EnumMember(Value = @"ATM")] ATM = 10,

        [EnumMember(Value = @"TRANSIT")] TRANSIT = 11
    }
}