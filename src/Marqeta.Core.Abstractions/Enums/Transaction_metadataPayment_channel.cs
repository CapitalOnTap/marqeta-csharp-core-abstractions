using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Transaction_metadataPayment_channel
    {
        [EnumMember(Value = @"OTHER")] OTHER = 0,

        [EnumMember(Value = @"ATM")] ATM = 1,

        [EnumMember(Value = @"ECOMMERCE")] ECOMMERCE = 2,

        [EnumMember(Value = @"MAIL")] MAIL = 3,

        [EnumMember(Value = @"PHONE")] PHONE = 4
    }
}