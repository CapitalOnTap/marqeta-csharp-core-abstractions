using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ShippingMethod
    {
        [EnumMember(Value = @"FEDEX_EXPEDITED")]
        FEDEX_EXPEDITED = 0,

        [EnumMember(Value = @"FEDEX_REGULAR")] FEDEX_REGULAR = 1,

        [EnumMember(Value = @"UPS_EXPEDITED")] UPS_EXPEDITED = 2,

        [EnumMember(Value = @"UPS_REGULAR")] UPS_REGULAR = 3,

        [EnumMember(Value = @"USPS_EXPEDITED")]
        USPS_EXPEDITED = 4,

        [EnumMember(Value = @"USPS_REGULAR")] USPS_REGULAR = 5
    }
}