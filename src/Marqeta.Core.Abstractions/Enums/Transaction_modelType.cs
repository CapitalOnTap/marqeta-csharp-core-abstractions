namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Transaction_modelType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit")]
        Gpa_credit = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_pending")]
        Gpa_credit_pending = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_pending_reversal")]
        Gpa_credit_pending_reversal = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_reversal")]
        Gpa_credit_reversal = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_networkload")]
        Gpa_credit_networkload = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_networkload_reversal")]
        Gpa_credit_networkload_reversal = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_debit_networkload")]
        Gpa_debit_networkload = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_debit")]
        Gpa_debit = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_debit_pending")]
        Gpa_debit_pending = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_debit_pending_reversal")]
        Gpa_debit_pending_reversal = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_grant")]
        Gpa_grant = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_issueroperator")]
        Gpa_credit_issueroperator = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_debit_issueroperator")]
        Gpa_debit_issueroperator = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_chargeback")]
        Gpa_credit_chargeback = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_chargeback_reversal")]
        Gpa_credit_chargeback_reversal = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_billpayment")]
        Gpa_credit_billpayment = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_authorization_billpayment")]
        Gpa_credit_authorization_billpayment = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = @"gpa_credit_authorization_billpayment_reversal")]
        Gpa_credit_authorization_billpayment_reversal = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_credit_pending")]
        Msa_credit_pending = 18,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_credit_pending_reversal")]
        Msa_credit_pending_reversal = 19,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_credit_reversal")]
        Msa_credit_reversal = 20,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_credit")]
        Msa_credit = 21,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_debit_pending")]
        Msa_debit_pending = 22,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_debit_pending_reversal")]
        Msa_debit_pending_reversal = 23,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_debit")]
        Msa_debit = 24,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_credit_chargeback")]
        Msa_credit_chargeback = 25,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msa_credit_chargeback_reversal")]
        Msa_credit_chargeback_reversal = 26,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authorization")]
        Authorization = 27,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authorization_advice")]
        Authorization_advice = 28,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authorization_reversal")]
        Authorization_reversal = 29,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authorization_clearing")]
        Authorization_clearing = 30,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authorization_reversal_issuerexpiration")]
        Authorization_reversal_issuerexpiration = 31,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authorization_clearing_chargeback")]
        Authorization_clearing_chargeback = 32,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authorization_clearing_chargeback_reversal")]
        Authorization_clearing_chargeback_reversal = 33,
    
        [System.Runtime.Serialization.EnumMember(Value = @"refund")]
        Refund = 34,
    
        [System.Runtime.Serialization.EnumMember(Value = @"pindebit_credit_adjustment")]
        Pindebit_credit_adjustment = 35,
    
        [System.Runtime.Serialization.EnumMember(Value = @"pindebit_atm_withdrawal")]
        Pindebit_atm_withdrawal = 36,
    
        [System.Runtime.Serialization.EnumMember(Value = @"pindebit_balanceinquiry")]
        Pindebit_balanceinquiry = 37,
    
        [System.Runtime.Serialization.EnumMember(Value = @"pindebit_cashback")]
        Pindebit_cashback = 38,
    
        [System.Runtime.Serialization.EnumMember(Value = @"pindebit")]
        Pindebit = 39,
    
        [System.Runtime.Serialization.EnumMember(Value = @"programreserve_credit")]
        Programreserve_credit = 40,
    
        [System.Runtime.Serialization.EnumMember(Value = @"programreserve_debit")]
        Programreserve_debit = 41,
    
        [System.Runtime.Serialization.EnumMember(Value = @"fee_charge_pending")]
        Fee_charge_pending = 42,
    
        [System.Runtime.Serialization.EnumMember(Value = @"fee_charge")]
        Fee_charge = 43,
    
        [System.Runtime.Serialization.EnumMember(Value = @"fee_charge_pending_refund")]
        Fee_charge_pending_refund = 44,
    
        [System.Runtime.Serialization.EnumMember(Value = @"funds_expire")]
        Funds_expire = 45,
    
        [System.Runtime.Serialization.EnumMember(Value = @"reward_earn")]
        Reward_earn = 46,
    
        [System.Runtime.Serialization.EnumMember(Value = @"transfer_peer")]
        Transfer_peer = 47,
    
        [System.Runtime.Serialization.EnumMember(Value = @"transfer_fee")]
        Transfer_fee = 48,
    
        [System.Runtime.Serialization.EnumMember(Value = @"account_credit")]
        Account_credit = 49,
    
        [System.Runtime.Serialization.EnumMember(Value = @"account_debit")]
        Account_debit = 50,
    
        [System.Runtime.Serialization.EnumMember(Value = @"unknown")]
        Unknown = 51,
    
    }
}