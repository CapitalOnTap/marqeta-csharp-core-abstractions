using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum DigitalWalletTokenTokenRequestorName
    {
        [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 0,

        [EnumMember(Value = @"APPLE_PAY")] APPLE_PAY = 1,

        [EnumMember(Value = @"SAMSUNG_PAY")] SAMSUNG_PAY = 2,

        [EnumMember(Value = @"ANDROID_PAY")] ANDROID_PAY = 3,

        [EnumMember(Value = @"MICROSOFT_PAY")] MICROSOFT_PAY = 4,

        [EnumMember(Value = @"VISA_CHECKOUT")] VISA_CHECKOUT = 5,

        [EnumMember(Value = @"FACEBOOK")] FACEBOOK = 6,

        [EnumMember(Value = @"NETFLIX")] NETFLIX = 7,

        [EnumMember(Value = @"FITBIT_PAY")] FITBIT_PAY = 8,

        [EnumMember(Value = @"GARMIN_PAY")] GARMIN_PAY = 9
    }
}