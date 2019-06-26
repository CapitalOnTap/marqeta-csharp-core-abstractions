using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Transaction_modelType
    {
        [EnumMember(Value = @"gpa_credit")] Gpa_credit = 0,

        [EnumMember(Value = @"gpa_credit_pending")]
        Gpa_credit_pending = 1,

        [EnumMember(Value = @"gpa_credit_pending_reversal")]
        Gpa_credit_pending_reversal = 2,

        [EnumMember(Value = @"gpa_credit_reversal")]
        Gpa_credit_reversal = 3,

        [EnumMember(Value = @"gpa_credit_networkload")]
        Gpa_credit_networkload = 4,

        [EnumMember(Value = @"gpa_credit_networkload_reversal")]
        Gpa_credit_networkload_reversal = 5,

        [EnumMember(Value = @"gpa_debit_networkload")]
        Gpa_debit_networkload = 6,

        [EnumMember(Value = @"gpa_debit")] Gpa_debit = 7,

        [EnumMember(Value = @"gpa_debit_pending")]
        Gpa_debit_pending = 8,

        [EnumMember(Value = @"gpa_debit_pending_reversal")]
        Gpa_debit_pending_reversal = 9,

        [EnumMember(Value = @"gpa_grant")] Gpa_grant = 10,

        [EnumMember(Value = @"gpa_credit_issueroperator")]
        Gpa_credit_issueroperator = 11,

        [EnumMember(Value = @"gpa_debit_issueroperator")]
        Gpa_debit_issueroperator = 12,

        [EnumMember(Value = @"gpa_credit_chargeback")]
        Gpa_credit_chargeback = 13,

        [EnumMember(Value = @"gpa_credit_chargeback_reversal")]
        Gpa_credit_chargeback_reversal = 14,

        [EnumMember(Value = @"gpa_credit_billpayment")]
        Gpa_credit_billpayment = 15,

        [EnumMember(Value = @"gpa_credit_authorization_billpayment")]
        Gpa_credit_authorization_billpayment = 16,

        [EnumMember(Value = @"gpa_credit_authorization_billpayment_reversal")]
        Gpa_credit_authorization_billpayment_reversal = 17,

        [EnumMember(Value = @"msa_credit_pending")]
        Msa_credit_pending = 18,

        [EnumMember(Value = @"msa_credit_pending_reversal")]
        Msa_credit_pending_reversal = 19,

        [EnumMember(Value = @"msa_credit_reversal")]
        Msa_credit_reversal = 20,

        [EnumMember(Value = @"msa_credit")] Msa_credit = 21,

        [EnumMember(Value = @"msa_debit_pending")]
        Msa_debit_pending = 22,

        [EnumMember(Value = @"msa_debit_pending_reversal")]
        Msa_debit_pending_reversal = 23,

        [EnumMember(Value = @"msa_debit")] Msa_debit = 24,

        [EnumMember(Value = @"msa_credit_chargeback")]
        Msa_credit_chargeback = 25,

        [EnumMember(Value = @"msa_credit_chargeback_reversal")]
        Msa_credit_chargeback_reversal = 26,

        [EnumMember(Value = @"authorization")] Authorization = 27,

        [EnumMember(Value = @"authorization_advice")]
        Authorization_advice = 28,

        [EnumMember(Value = @"authorization_reversal")]
        Authorization_reversal = 29,

        [EnumMember(Value = @"authorization_clearing")]
        Authorization_clearing = 30,

        [EnumMember(Value = @"authorization_reversal_issuerexpiration")]
        Authorization_reversal_issuerexpiration = 31,

        [EnumMember(Value = @"authorization_clearing_chargeback")]
        Authorization_clearing_chargeback = 32,

        [EnumMember(Value = @"authorization_clearing_chargeback_reversal")]
        Authorization_clearing_chargeback_reversal = 33,

        [EnumMember(Value = @"refund")] Refund = 34,

        [EnumMember(Value = @"pindebit_credit_adjustment")]
        Pindebit_credit_adjustment = 35,

        [EnumMember(Value = @"pindebit_atm_withdrawal")]
        Pindebit_atm_withdrawal = 36,

        [EnumMember(Value = @"pindebit_balanceinquiry")]
        Pindebit_balanceinquiry = 37,

        [EnumMember(Value = @"pindebit_cashback")]
        Pindebit_cashback = 38,

        [EnumMember(Value = @"pindebit")] Pindebit = 39,

        [EnumMember(Value = @"programreserve_credit")]
        Programreserve_credit = 40,

        [EnumMember(Value = @"programreserve_debit")]
        Programreserve_debit = 41,

        [EnumMember(Value = @"fee_charge_pending")]
        Fee_charge_pending = 42,

        [EnumMember(Value = @"fee_charge")] Fee_charge = 43,

        [EnumMember(Value = @"fee_charge_pending_refund")]
        Fee_charge_pending_refund = 44,

        [EnumMember(Value = @"funds_expire")] Funds_expire = 45,

        [EnumMember(Value = @"reward_earn")] Reward_earn = 46,

        [EnumMember(Value = @"transfer_peer")] Transfer_peer = 47,

        [EnumMember(Value = @"transfer_fee")] Transfer_fee = 48,

        [EnumMember(Value = @"account_credit")]
        Account_credit = 49,

        [EnumMember(Value = @"account_debit")] Account_debit = 50,

        [EnumMember(Value = @"unknown")] Unknown = 51
    }
}