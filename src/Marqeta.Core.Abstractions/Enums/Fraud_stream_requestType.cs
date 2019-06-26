namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Fraud_stream_requestType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_PENDING")]
        GPA_CREDIT_PENDING = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_PENDING_REVERSAL")]
        GPA_CREDIT_PENDING_REVERSAL = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_REVERSAL")]
        GPA_CREDIT_REVERSAL = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT")]
        GPA_CREDIT = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_DEBIT")]
        GPA_DEBIT = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_DEBIT_PENDING_REVERSAL")]
        GPA_DEBIT_PENDING_REVERSAL = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_DEBIT_REVERSAL")]
        GPA_DEBIT_REVERSAL = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_GRANT")]
        GPA_GRANT = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_NETWORK_LOAD")]
        GPA_CREDIT_NETWORK_LOAD = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_NETWORK_LOAD_REVERSAL")]
        GPA_CREDIT_NETWORK_LOAD_REVERSAL = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_DEBIT_NETWORK_LOAD")]
        GPA_DEBIT_NETWORK_LOAD = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_ISSUER_OPERATOR")]
        GPA_CREDIT_ISSUER_OPERATOR = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_DEBIT_ISSUER_OPERATOR")]
        GPA_DEBIT_ISSUER_OPERATOR = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION")]
        GPA_CREDIT_AUTHORIZATION = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION_REVERSAL")]
        GPA_CREDIT_AUTHORIZATION_REVERSAL = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_CHARGEBACK")]
        GPA_CREDIT_CHARGEBACK = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_CHARGEBACK_REVERSAL")]
        GPA_CREDIT_CHARGEBACK_REVERSAL = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_BILLPAYMENT")]
        GPA_CREDIT_BILLPAYMENT = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION_BILLPAYMENT")]
        GPA_CREDIT_AUTHORIZATION_BILLPAYMENT = 18,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION_BILLPAYMENT_REVERSAL")]
        GPA_CREDIT_AUTHORIZATION_BILLPAYMENT_REVERSAL = 19,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT_PENDING")]
        MSA_CREDIT_PENDING = 20,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT_PENDING_REVERSAL")]
        MSA_CREDIT_PENDING_REVERSAL = 21,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT_REVERSAL")]
        MSA_CREDIT_REVERSAL = 22,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT")]
        MSA_CREDIT = 23,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_DEBIT_REVERSAL")]
        MSA_DEBIT_REVERSAL = 24,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_DEBIT_PENDING_REVERSAL")]
        MSA_DEBIT_PENDING_REVERSAL = 25,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_DEBIT")]
        MSA_DEBIT = 26,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT_AUTHORIZATION")]
        MSA_CREDIT_AUTHORIZATION = 27,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT_AUTHORIZATION_REVERSAL")]
        MSA_CREDIT_AUTHORIZATION_REVERSAL = 28,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT_CHARGEBACK")]
        MSA_CREDIT_CHARGEBACK = 29,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MSA_CREDIT_CHARGEBACK_REVERSAL")]
        MSA_CREDIT_CHARGEBACK_REVERSAL = 30,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION")]
        AUTHORIZATION = 31,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_INCREMENTAL")]
        AUTHORIZATION_INCREMENTAL = 32,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_ADVICE")]
        AUTHORIZATION_ADVICE = 33,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_REVERSAL")]
        AUTHORIZATION_REVERSAL = 34,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING")]
        AUTHORIZATION_CLEARING = 35,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_NETWORK_FEE")]
        AUTHORIZATION_CLEARING_NETWORK_FEE = 36,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_REPRESENTMENT")]
        AUTHORIZATION_CLEARING_REPRESENTMENT = 37,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION")]
        AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION = 38,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK")]
        AUTHORIZATION_CLEARING_CHARGEBACK = 39,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_REVERSAL")]
        AUTHORIZATION_CLEARING_CHARGEBACK_REVERSAL = 40,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_COMPLETED")]
        AUTHORIZATION_CLEARING_CHARGEBACK_COMPLETED = 41,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_CREDIT")]
        AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_CREDIT = 42,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_DEBIT")]
        AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_DEBIT = 43,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_WRITEOFF")]
        AUTHORIZATION_CLEARING_CHARGEBACK_WRITEOFF = 44,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_FUNDING_AUTHORIZATION")]
        ACCOUNT_FUNDING_AUTHORIZATION = 45,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_FUNDING_AUTHORIZATION_CLEARING")]
        ACCOUNT_FUNDING_AUTHORIZATION_CLEARING = 46,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE")]
        ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE = 47,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_FUNDING_AUTHORIZATION_REVERSAL")]
        ACCOUNT_FUNDING_AUTHORIZATION_REVERSAL = 48,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE_REVERSAL")]
        ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE_REVERSAL = 49,
    
        [System.Runtime.Serialization.EnumMember(Value = @"BALANCE_INQUIRY")]
        BALANCE_INQUIRY = 50,
    
        [System.Runtime.Serialization.EnumMember(Value = @"REFUND")]
        REFUND = 51,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CREDIT_ADJUSTMENT")]
        PIN_DEBIT_CREDIT_ADJUSTMENT = 52,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_DEBIT_ADJUSTMENT")]
        PIN_DEBIT_DEBIT_ADJUSTMENT = 53,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_ATM_WITHDRAWAL")]
        PIN_DEBIT_ATM_WITHDRAWAL = 54,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_QUASI_CASH")]
        PIN_DEBIT_QUASI_CASH = 55,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_BALANCE_INQUIRY")]
        PIN_DEBIT_BALANCE_INQUIRY = 56,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CASHBACK")]
        PIN_DEBIT_CASHBACK = 57,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CHECK_AVS")]
        PIN_DEBIT_CHECK_AVS = 58,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_FINANCIAL_DEPOSIT")]
        PIN_DEBIT_FINANCIAL_DEPOSIT = 59,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_FINANCIAL_REFUND")]
        PIN_DEBIT_FINANCIAL_REFUND = 60,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_FINANCIAL_REVERSAL")]
        PIN_DEBIT_FINANCIAL_REVERSAL = 61,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_FINANCIAL_REFUND_REVERSAL")]
        PIN_DEBIT_FINANCIAL_REFUND_REVERSAL = 62,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_TRANSFER")]
        PIN_DEBIT_TRANSFER = 63,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT")]
        PIN_DEBIT = 64,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_REPRESENTMENT")]
        PIN_DEBIT_REPRESENTMENT = 65,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_AUTHORIZATION")]
        PIN_DEBIT_AUTHORIZATION = 66,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_AUTHORIZATION_CLEARING")]
        PIN_DEBIT_AUTHORIZATION_CLEARING = 67,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION")]
        PIN_DEBIT_AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION = 68,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CHARGEBACK")]
        PIN_DEBIT_CHARGEBACK = 69,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_REVERSAL")]
        PIN_DEBIT_CHARGEBACK_REVERSAL = 70,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_COMPLETED")]
        PIN_DEBIT_CHARGEBACK_COMPLETED = 71,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_PROVISIONAL_CREDIT")]
        PIN_DEBIT_CHARGEBACK_PROVISIONAL_CREDIT = 72,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_PROVISIONAL_DEBIT")]
        PIN_DEBIT_CHARGEBACK_PROVISIONAL_DEBIT = 73,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_WRITEOFF")]
        PIN_DEBIT_CHARGEBACK_WRITEOFF = 74,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT")]
        DIRECT_DEPOSIT_CREDIT = 75,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT")]
        DIRECT_DEPOSIT_DEBIT = 76,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_PENDING")]
        DIRECT_DEPOSIT_CREDIT_PENDING = 77,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_PENDING")]
        DIRECT_DEPOSIT_DEBIT_PENDING = 78,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_REJECT")]
        DIRECT_DEPOSIT_CREDIT_REJECT = 79,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_REJECT")]
        DIRECT_DEPOSIT_DEBIT_REJECT = 80,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_PENDING_REVERSAL")]
        DIRECT_DEPOSIT_CREDIT_PENDING_REVERSAL = 81,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_PENDING_REVERSAL")]
        DIRECT_DEPOSIT_DEBIT_PENDING_REVERSAL = 82,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_REVERSAL")]
        DIRECT_DEPOSIT_CREDIT_REVERSAL = 83,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_REVERSAL")]
        DIRECT_DEPOSIT_DEBIT_REVERSAL = 84,
    
        [System.Runtime.Serialization.EnumMember(Value = @"FEE_CHARGE_PENDING")]
        FEE_CHARGE_PENDING = 85,
    
        [System.Runtime.Serialization.EnumMember(Value = @"FEE_CHARGE")]
        FEE_CHARGE = 86,
    
        [System.Runtime.Serialization.EnumMember(Value = @"FEE_CHARGE_REFUND")]
        FEE_CHARGE_REFUND = 87,
    
        [System.Runtime.Serialization.EnumMember(Value = @"FUNDS_EXPIRE")]
        FUNDS_EXPIRE = 88,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PROGRAMRESERVE_CREDIT")]
        PROGRAMRESERVE_CREDIT = 89,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PROGRAMRESERVE_DEBIT")]
        PROGRAMRESERVE_DEBIT = 90,
    
        [System.Runtime.Serialization.EnumMember(Value = @"REWARD_EARN")]
        REWARD_EARN = 91,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_PEER")]
        TRANSFER_PEER = 92,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_FEE")]
        TRANSFER_FEE = 93,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_CREDIT")]
        ACCOUNT_CREDIT = 94,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_DEBIT")]
        ACCOUNT_DEBIT = 95,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_PROGRAM")]
        TRANSFER_PROGRAM = 96,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZATION_STANDIN")]
        AUTHORIZATION_STANDIN = 97,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PIN_DEBIT_STANDIN")]
        PIN_DEBIT_STANDIN = 98,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TOKEN_ACTIVATION_REQUEST")]
        TOKEN_ACTIVATION_REQUEST = 99,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TOKEN_ADVICE")]
        TOKEN_ADVICE = 100,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PTC_DEBIT")]
        PTC_DEBIT = 101,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PTC_PENDING_DB")]
        PTC_PENDING_DB = 102,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PTC_DB_REV")]
        PTC_DB_REV = 103,
    
        [System.Runtime.Serialization.EnumMember(Value = @"BILLPAYMENT")]
        BILLPAYMENT = 104,
    
        [System.Runtime.Serialization.EnumMember(Value = @"BILLPAYMENT_CLEARING")]
        BILLPAYMENT_CLEARING = 105,
    
        [System.Runtime.Serialization.EnumMember(Value = @"BILLPAYMENT_REVERSAL")]
        BILLPAYMENT_REVERSAL = 106,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACH_PUSH_PENDING")]
        ACH_PUSH_PENDING = 107,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACH_PULL_PENDING")]
        ACH_PULL_PENDING = 108,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACH_PUSH")]
        ACH_PUSH = 109,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACH_PULL")]
        ACH_PULL = 110,
    
        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 111,
    
    }
}