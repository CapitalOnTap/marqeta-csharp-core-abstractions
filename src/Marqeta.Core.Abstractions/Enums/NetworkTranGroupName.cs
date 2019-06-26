using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum NetworkTranGroupName
    {
        [EnumMember(Value = @"ISSUER_FEE")] ISSUER_FEE = 0,

        [EnumMember(Value = @"SWITCH_FEE")] SWITCH_FEE = 1,

        [EnumMember(Value = @"PINDEBIT_ASSOC_FEE")]
        PINDEBIT_ASSOC_FEE = 2,

        [EnumMember(Value = @"ACQUIRER_FEE")] ACQUIRER_FEE = 3,

        [EnumMember(Value = @"ATM_FEE")] ATM_FEE = 4,

        [EnumMember(Value = @"AFD_FEE")] AFD_FEE = 5,

        [EnumMember(Value = @"INTERCHANGE_FEE")]
        INTERCHANGE_FEE = 6,

        [EnumMember(Value = @"MFD_FEE")] MFD_FEE = 7,

        [EnumMember(Value = @"MFD_ACQUIRER_FEE")]
        MFD_ACQUIRER_FEE = 8,

        [EnumMember(Value = @"ISSUER_LOAD_SURCHARGE_FEE")]
        ISSUER_LOAD_SURCHARGE_FEE = 9,

        [EnumMember(Value = @"REAL_TIME_FEE")] REAL_TIME_FEE = 10,

        [EnumMember(Value = @"CROSS_BORDER_CARDHOLDER_FEE")]
        CROSS_BORDER_CARDHOLDER_FEE = 11,

        [EnumMember(Value = @"CROSS_BORDER_ISSUER_FEE")]
        CROSS_BORDER_ISSUER_FEE = 12,

        [EnumMember(Value = @"CUR_CONV_CARDHOLDER_FEE")]
        CUR_CONV_CARDHOLDER_FEE = 13,

        [EnumMember(Value = @"CUR_CONV_ISSUER_FEE")]
        CUR_CONV_ISSUER_FEE = 14,

        [EnumMember(Value = @"PROGRAM_FEE")] PROGRAM_FEE = 15,

        [EnumMember(Value = @"PURCHASE")] PURCHASE = 16,

        [EnumMember(Value = @"REFUND")] REFUND = 17,

        [EnumMember(Value = @"DEPOSIT")] DEPOSIT = 18,

        [EnumMember(Value = @"MCC_PADDING")] MCC_PADDING = 19,

        [EnumMember(Value = @"CASHBACK")] CASHBACK = 20,

        [EnumMember(Value = @"CHARGEBACK")] CHARGEBACK = 21,

        [EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT")]
        DIRECT_DEPOSIT_DEBIT = 22,

        [EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT")]
        DIRECT_DEPOSIT_CREDIT = 23,

        [EnumMember(Value = @"BILLPAYMENT")] BILLPAYMENT = 24,

        [EnumMember(Value = @"UNHANDLED_FEE")] UNHANDLED_FEE = 25,

        [EnumMember(Value = @"UNKNOWN_FEE")] UNKNOWN_FEE = 26,

        [EnumMember(Value = @"OVERDRAFT")] OVERDRAFT = 27,

        [EnumMember(Value = @"GPA_CREDIT")] GPA_CREDIT = 28
    }
}