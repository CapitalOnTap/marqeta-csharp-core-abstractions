using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Jit_funding_apiMethod
    {
        [EnumMember(Value = @"pgfs_authorization")]
        Pgfs_authorization = 0,

        [EnumMember(Value = @"pgfs_authorization_incremental")]
        Pgfs_authorization_incremental = 1,

        [EnumMember(Value = @"pgfs_authorization_capture")]
        Pgfs_authorization_capture = 2,

        [EnumMember(Value = @"pgfs_authorization_reversal")]
        Pgfs_authorization_reversal = 3,

        [EnumMember(Value = @"pgfs_auth_plus_capture")]
        Pgfs_auth_plus_capture = 4,

        [EnumMember(Value = @"pgfs_refund")] Pgfs_refund = 5,

        [EnumMember(Value = @"pgfs_force_capture")]
        Pgfs_force_capture = 6,

        [EnumMember(Value = @"pgfs_authorization_capture_chargeback")]
        Pgfs_authorization_capture_chargeback = 7,

        [EnumMember(Value = @"pgfs_authorization_capture_chargeback_reversal")]
        Pgfs_authorization_capture_chargeback_reversal = 8,

        [EnumMember(Value = @"pgfs_pindebit_chargeback")]
        Pgfs_pindebit_chargeback = 9,

        [EnumMember(Value = @"pgfs_pindebit_chargeback_reversal")]
        Pgfs_pindebit_chargeback_reversal = 10,

        [EnumMember(Value = @"pgfs_directdeposit_credit")]
        Pgfs_directdeposit_credit = 11,

        [EnumMember(Value = @"pgfs_directdeposit_debit")]
        Pgfs_directdeposit_debit = 12,

        [EnumMember(Value = @"pgfs_directdeposit_credit_reversal")]
        Pgfs_directdeposit_credit_reversal = 13,

        [EnumMember(Value = @"pgfs_directdeposit_debit_reversal")]
        Pgfs_directdeposit_debit_reversal = 14,

        [EnumMember(Value = @"pgfs_adjustment_credit")]
        Pgfs_adjustment_credit = 15,

        [EnumMember(Value = @"pgfs_adjustment_debit")]
        Pgfs_adjustment_debit = 16,

        [EnumMember(Value = @"pgfs_auth_plus_capture_standin")]
        Pgfs_auth_plus_capture_standin = 17,

        [EnumMember(Value = @"pgfs_authorization_standin")]
        Pgfs_authorization_standin = 18,

        [EnumMember(Value = @"pgfs_billpayment")]
        Pgfs_billpayment = 19,

        [EnumMember(Value = @"pgfs_billpayment_capture")]
        Pgfs_billpayment_capture = 20,

        [EnumMember(Value = @"pgfs_billpayment_reversal")]
        Pgfs_billpayment_reversal = 21
    }
}