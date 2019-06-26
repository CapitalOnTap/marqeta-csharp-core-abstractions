using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Network_fee_modelType
    {
        [EnumMember(Value = @"ISSUER_FEE")] ISSUER_FEE = 0,

        [EnumMember(Value = @"SWITCH_FEE")] SWITCH_FEE = 1,

        [EnumMember(Value = @"PINDEBIT_ASSOC_FEE")]
        PINDEBIT_ASSOC_FEE = 2,

        [EnumMember(Value = @"ACQUIRER_FEE")] ACQUIRER_FEE = 3,

        [EnumMember(Value = @"INTERCHANGE_FEE")]
        INTERCHANGE_FEE = 4,

        [EnumMember(Value = @"CUR_CONV_CARDHOLDER_FEE")]
        CUR_CONV_CARDHOLDER_FEE = 5,

        [EnumMember(Value = @"CUR_CONV_ISSUER_FEE")]
        CUR_CONV_ISSUER_FEE = 6,

        [EnumMember(Value = @"CROSS_BORDER_ISSUER_FEE")]
        CROSS_BORDER_ISSUER_FEE = 7
    }
}