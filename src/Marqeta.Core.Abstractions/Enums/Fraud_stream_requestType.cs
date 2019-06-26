using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Fraud_stream_requestType
    {
        [EnumMember(Value = @"GPA_CREDIT_PENDING")]
        GPA_CREDIT_PENDING = 0,

        [EnumMember(Value = @"GPA_CREDIT_PENDING_REVERSAL")]
        GPA_CREDIT_PENDING_REVERSAL = 1,

        [EnumMember(Value = @"GPA_CREDIT_REVERSAL")]
        GPA_CREDIT_REVERSAL = 2,

        [EnumMember(Value = @"GPA_CREDIT")] GPA_CREDIT = 3,

        [EnumMember(Value = @"GPA_DEBIT")] GPA_DEBIT = 4,

        [EnumMember(Value = @"GPA_DEBIT_PENDING_REVERSAL")]
        GPA_DEBIT_PENDING_REVERSAL = 5,

        [EnumMember(Value = @"GPA_DEBIT_REVERSAL")]
        GPA_DEBIT_REVERSAL = 6,

        [EnumMember(Value = @"GPA_GRANT")] GPA_GRANT = 7,

        [EnumMember(Value = @"GPA_CREDIT_NETWORK_LOAD")]
        GPA_CREDIT_NETWORK_LOAD = 8,

        [EnumMember(Value = @"GPA_CREDIT_NETWORK_LOAD_REVERSAL")]
        GPA_CREDIT_NETWORK_LOAD_REVERSAL = 9,

        [EnumMember(Value = @"GPA_DEBIT_NETWORK_LOAD")]
        GPA_DEBIT_NETWORK_LOAD = 10,

        [EnumMember(Value = @"GPA_CREDIT_ISSUER_OPERATOR")]
        GPA_CREDIT_ISSUER_OPERATOR = 11,

        [EnumMember(Value = @"GPA_DEBIT_ISSUER_OPERATOR")]
        GPA_DEBIT_ISSUER_OPERATOR = 12,

        [EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION")]
        GPA_CREDIT_AUTHORIZATION = 13,

        [EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION_REVERSAL")]
        GPA_CREDIT_AUTHORIZATION_REVERSAL = 14,

        [EnumMember(Value = @"GPA_CREDIT_CHARGEBACK")]
        GPA_CREDIT_CHARGEBACK = 15,

        [EnumMember(Value = @"GPA_CREDIT_CHARGEBACK_REVERSAL")]
        GPA_CREDIT_CHARGEBACK_REVERSAL = 16,

        [EnumMember(Value = @"GPA_CREDIT_BILLPAYMENT")]
        GPA_CREDIT_BILLPAYMENT = 17,

        [EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION_BILLPAYMENT")]
        GPA_CREDIT_AUTHORIZATION_BILLPAYMENT = 18,

        [EnumMember(Value = @"GPA_CREDIT_AUTHORIZATION_BILLPAYMENT_REVERSAL")]
        GPA_CREDIT_AUTHORIZATION_BILLPAYMENT_REVERSAL = 19,

        [EnumMember(Value = @"MSA_CREDIT_PENDING")]
        MSA_CREDIT_PENDING = 20,

        [EnumMember(Value = @"MSA_CREDIT_PENDING_REVERSAL")]
        MSA_CREDIT_PENDING_REVERSAL = 21,

        [EnumMember(Value = @"MSA_CREDIT_REVERSAL")]
        MSA_CREDIT_REVERSAL = 22,

        [EnumMember(Value = @"MSA_CREDIT")] MSA_CREDIT = 23,

        [EnumMember(Value = @"MSA_DEBIT_REVERSAL")]
        MSA_DEBIT_REVERSAL = 24,

        [EnumMember(Value = @"MSA_DEBIT_PENDING_REVERSAL")]
        MSA_DEBIT_PENDING_REVERSAL = 25,

        [EnumMember(Value = @"MSA_DEBIT")] MSA_DEBIT = 26,

        [EnumMember(Value = @"MSA_CREDIT_AUTHORIZATION")]
        MSA_CREDIT_AUTHORIZATION = 27,

        [EnumMember(Value = @"MSA_CREDIT_AUTHORIZATION_REVERSAL")]
        MSA_CREDIT_AUTHORIZATION_REVERSAL = 28,

        [EnumMember(Value = @"MSA_CREDIT_CHARGEBACK")]
        MSA_CREDIT_CHARGEBACK = 29,

        [EnumMember(Value = @"MSA_CREDIT_CHARGEBACK_REVERSAL")]
        MSA_CREDIT_CHARGEBACK_REVERSAL = 30,

        [EnumMember(Value = @"AUTHORIZATION")] AUTHORIZATION = 31,

        [EnumMember(Value = @"AUTHORIZATION_INCREMENTAL")]
        AUTHORIZATION_INCREMENTAL = 32,

        [EnumMember(Value = @"AUTHORIZATION_ADVICE")]
        AUTHORIZATION_ADVICE = 33,

        [EnumMember(Value = @"AUTHORIZATION_REVERSAL")]
        AUTHORIZATION_REVERSAL = 34,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING")]
        AUTHORIZATION_CLEARING = 35,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_NETWORK_FEE")]
        AUTHORIZATION_CLEARING_NETWORK_FEE = 36,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_REPRESENTMENT")]
        AUTHORIZATION_CLEARING_REPRESENTMENT = 37,

        [EnumMember(Value = @"AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION")]
        AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION = 38,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK")]
        AUTHORIZATION_CLEARING_CHARGEBACK = 39,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_REVERSAL")]
        AUTHORIZATION_CLEARING_CHARGEBACK_REVERSAL = 40,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_COMPLETED")]
        AUTHORIZATION_CLEARING_CHARGEBACK_COMPLETED = 41,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_CREDIT")]
        AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_CREDIT = 42,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_DEBIT")]
        AUTHORIZATION_CLEARING_CHARGEBACK_PROVISIONAL_DEBIT = 43,

        [EnumMember(Value = @"AUTHORIZATION_CLEARING_CHARGEBACK_WRITEOFF")]
        AUTHORIZATION_CLEARING_CHARGEBACK_WRITEOFF = 44,

        [EnumMember(Value = @"ACCOUNT_FUNDING_AUTHORIZATION")]
        ACCOUNT_FUNDING_AUTHORIZATION = 45,

        [EnumMember(Value = @"ACCOUNT_FUNDING_AUTHORIZATION_CLEARING")]
        ACCOUNT_FUNDING_AUTHORIZATION_CLEARING = 46,

        [EnumMember(Value = @"ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE")]
        ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE = 47,

        [EnumMember(Value = @"ACCOUNT_FUNDING_AUTHORIZATION_REVERSAL")]
        ACCOUNT_FUNDING_AUTHORIZATION_REVERSAL = 48,

        [EnumMember(Value = @"ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE_REVERSAL")]
        ACCOUNT_FUNDING_PLUS_AUTH_CAPTURE_REVERSAL = 49,

        [EnumMember(Value = @"BALANCE_INQUIRY")]
        BALANCE_INQUIRY = 50,

        [EnumMember(Value = @"REFUND")] REFUND = 51,

        [EnumMember(Value = @"PIN_DEBIT_CREDIT_ADJUSTMENT")]
        PIN_DEBIT_CREDIT_ADJUSTMENT = 52,

        [EnumMember(Value = @"PIN_DEBIT_DEBIT_ADJUSTMENT")]
        PIN_DEBIT_DEBIT_ADJUSTMENT = 53,

        [EnumMember(Value = @"PIN_DEBIT_ATM_WITHDRAWAL")]
        PIN_DEBIT_ATM_WITHDRAWAL = 54,

        [EnumMember(Value = @"PIN_DEBIT_QUASI_CASH")]
        PIN_DEBIT_QUASI_CASH = 55,

        [EnumMember(Value = @"PIN_DEBIT_BALANCE_INQUIRY")]
        PIN_DEBIT_BALANCE_INQUIRY = 56,

        [EnumMember(Value = @"PIN_DEBIT_CASHBACK")]
        PIN_DEBIT_CASHBACK = 57,

        [EnumMember(Value = @"PIN_DEBIT_CHECK_AVS")]
        PIN_DEBIT_CHECK_AVS = 58,

        [EnumMember(Value = @"PIN_DEBIT_FINANCIAL_DEPOSIT")]
        PIN_DEBIT_FINANCIAL_DEPOSIT = 59,

        [EnumMember(Value = @"PIN_DEBIT_FINANCIAL_REFUND")]
        PIN_DEBIT_FINANCIAL_REFUND = 60,

        [EnumMember(Value = @"PIN_DEBIT_FINANCIAL_REVERSAL")]
        PIN_DEBIT_FINANCIAL_REVERSAL = 61,

        [EnumMember(Value = @"PIN_DEBIT_FINANCIAL_REFUND_REVERSAL")]
        PIN_DEBIT_FINANCIAL_REFUND_REVERSAL = 62,

        [EnumMember(Value = @"PIN_DEBIT_TRANSFER")]
        PIN_DEBIT_TRANSFER = 63,

        [EnumMember(Value = @"PIN_DEBIT")] PIN_DEBIT = 64,

        [EnumMember(Value = @"PIN_DEBIT_REPRESENTMENT")]
        PIN_DEBIT_REPRESENTMENT = 65,

        [EnumMember(Value = @"PIN_DEBIT_AUTHORIZATION")]
        PIN_DEBIT_AUTHORIZATION = 66,

        [EnumMember(Value = @"PIN_DEBIT_AUTHORIZATION_CLEARING")]
        PIN_DEBIT_AUTHORIZATION_CLEARING = 67,

        [EnumMember(Value = @"PIN_DEBIT_AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION")]
        PIN_DEBIT_AUTHORIZATION_REVERSAL_ISSUER_EXPIRATION = 68,

        [EnumMember(Value = @"PIN_DEBIT_CHARGEBACK")]
        PIN_DEBIT_CHARGEBACK = 69,

        [EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_REVERSAL")]
        PIN_DEBIT_CHARGEBACK_REVERSAL = 70,

        [EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_COMPLETED")]
        PIN_DEBIT_CHARGEBACK_COMPLETED = 71,

        [EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_PROVISIONAL_CREDIT")]
        PIN_DEBIT_CHARGEBACK_PROVISIONAL_CREDIT = 72,

        [EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_PROVISIONAL_DEBIT")]
        PIN_DEBIT_CHARGEBACK_PROVISIONAL_DEBIT = 73,

        [EnumMember(Value = @"PIN_DEBIT_CHARGEBACK_WRITEOFF")]
        PIN_DEBIT_CHARGEBACK_WRITEOFF = 74,

        [EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT")]
        DIRECT_DEPOSIT_CREDIT = 75,

        [EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT")]
        DIRECT_DEPOSIT_DEBIT = 76,

        [EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_PENDING")]
        DIRECT_DEPOSIT_CREDIT_PENDING = 77,

        [EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_PENDING")]
        DIRECT_DEPOSIT_DEBIT_PENDING = 78,

        [EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_REJECT")]
        DIRECT_DEPOSIT_CREDIT_REJECT = 79,

        [EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_REJECT")]
        DIRECT_DEPOSIT_DEBIT_REJECT = 80,

        [EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_PENDING_REVERSAL")]
        DIRECT_DEPOSIT_CREDIT_PENDING_REVERSAL = 81,

        [EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_PENDING_REVERSAL")]
        DIRECT_DEPOSIT_DEBIT_PENDING_REVERSAL = 82,

        [EnumMember(Value = @"DIRECT_DEPOSIT_CREDIT_REVERSAL")]
        DIRECT_DEPOSIT_CREDIT_REVERSAL = 83,

        [EnumMember(Value = @"DIRECT_DEPOSIT_DEBIT_REVERSAL")]
        DIRECT_DEPOSIT_DEBIT_REVERSAL = 84,

        [EnumMember(Value = @"FEE_CHARGE_PENDING")]
        FEE_CHARGE_PENDING = 85,

        [EnumMember(Value = @"FEE_CHARGE")] FEE_CHARGE = 86,

        [EnumMember(Value = @"FEE_CHARGE_REFUND")]
        FEE_CHARGE_REFUND = 87,

        [EnumMember(Value = @"FUNDS_EXPIRE")] FUNDS_EXPIRE = 88,

        [EnumMember(Value = @"PROGRAMRESERVE_CREDIT")]
        PROGRAMRESERVE_CREDIT = 89,

        [EnumMember(Value = @"PROGRAMRESERVE_DEBIT")]
        PROGRAMRESERVE_DEBIT = 90,

        [EnumMember(Value = @"REWARD_EARN")] REWARD_EARN = 91,

        [EnumMember(Value = @"TRANSFER_PEER")] TRANSFER_PEER = 92,

        [EnumMember(Value = @"TRANSFER_FEE")] TRANSFER_FEE = 93,

        [EnumMember(Value = @"ACCOUNT_CREDIT")]
        ACCOUNT_CREDIT = 94,

        [EnumMember(Value = @"ACCOUNT_DEBIT")] ACCOUNT_DEBIT = 95,

        [EnumMember(Value = @"TRANSFER_PROGRAM")]
        TRANSFER_PROGRAM = 96,

        [EnumMember(Value = @"AUTHORIZATION_STANDIN")]
        AUTHORIZATION_STANDIN = 97,

        [EnumMember(Value = @"PIN_DEBIT_STANDIN")]
        PIN_DEBIT_STANDIN = 98,

        [EnumMember(Value = @"TOKEN_ACTIVATION_REQUEST")]
        TOKEN_ACTIVATION_REQUEST = 99,

        [EnumMember(Value = @"TOKEN_ADVICE")] TOKEN_ADVICE = 100,

        [EnumMember(Value = @"PTC_DEBIT")] PTC_DEBIT = 101,

        [EnumMember(Value = @"PTC_PENDING_DB")]
        PTC_PENDING_DB = 102,

        [EnumMember(Value = @"PTC_DB_REV")] PTC_DB_REV = 103,

        [EnumMember(Value = @"BILLPAYMENT")] BILLPAYMENT = 104,

        [EnumMember(Value = @"BILLPAYMENT_CLEARING")]
        BILLPAYMENT_CLEARING = 105,

        [EnumMember(Value = @"BILLPAYMENT_REVERSAL")]
        BILLPAYMENT_REVERSAL = 106,

        [EnumMember(Value = @"ACH_PUSH_PENDING")]
        ACH_PUSH_PENDING = 107,

        [EnumMember(Value = @"ACH_PULL_PENDING")]
        ACH_PULL_PENDING = 108,

        [EnumMember(Value = @"ACH_PUSH")] ACH_PUSH = 109,

        [EnumMember(Value = @"ACH_PULL")] ACH_PULL = 110,

        [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 111
    }
}