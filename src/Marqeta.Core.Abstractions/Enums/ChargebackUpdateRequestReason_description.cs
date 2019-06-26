﻿using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ChargebackUpdateRequestReason_description
    {
        [EnumMember(Value = @"SERVICE_NOT_PROVIDED_MERCHANDISE_NOT_RECEIVED")]
        SERVICE_NOT_PROVIDED_MERCHANDISE_NOT_RECEIVED = 0,

        [EnumMember(Value = @"CANCELLED_RECURRING_TRANSACTION")]
        CANCELLED_RECURRING_TRANSACTION = 1,

        [EnumMember(Value = @"NOT_AS_DESCRIBED_OR_DEFECTIVE_MERCHANDISE")]
        NOT_AS_DESCRIBED_OR_DEFECTIVE_MERCHANDISE = 2,

        [EnumMember(Value = @"FRAUD_MULTIPLE_TRANSACTIONS")]
        FRAUD_MULTIPLE_TRANSACTIONS = 3,

        [EnumMember(Value = @"FRAUD_TRANSACTION")]
        FRAUD_TRANSACTION = 4,

        [EnumMember(Value = @"NO_AUTHORIZATION")]
        NO_AUTHORIZATION = 5,

        [EnumMember(Value = @"LATE_PRESENTMENT")]
        LATE_PRESENTMENT = 6,

        [EnumMember(Value = @"TRANSACTION_NOT_RECOGNIZED")]
        TRANSACTION_NOT_RECOGNIZED = 7,

        [EnumMember(Value = @"INCORRECT_CURRENCY")]
        INCORRECT_CURRENCY = 8,

        [EnumMember(Value = @"INCORRECT_TRANSACTION_CODE")]
        INCORRECT_TRANSACTION_CODE = 9,

        [EnumMember(Value = @"INCORRECT_CURRENCY_OR_TRANSACTION_CODE")]
        INCORRECT_CURRENCY_OR_TRANSACTION_CODE = 10,

        [EnumMember(Value = @"INCORRECT_TRANSACTION_AMOUNT")]
        INCORRECT_TRANSACTION_AMOUNT = 11,

        [EnumMember(Value = @"INCORRECT_ACCOUNT_NUMBER")]
        INCORRECT_ACCOUNT_NUMBER = 12,

        [EnumMember(Value = @"INCORRECT_TRANSACTION_AMOUNT_OR_ACCOUNT_NUMBER")]
        INCORRECT_TRANSACTION_AMOUNT_OR_ACCOUNT_NUMBER = 13,

        [EnumMember(Value = @"NOT_AUTHORIZED_CARD_PRESENT")]
        NOT_AUTHORIZED_CARD_PRESENT = 14,

        [EnumMember(Value = @"NOT_AUTHORIZED_CARD_ABSENT")]
        NOT_AUTHORIZED_CARD_ABSENT = 15,

        [EnumMember(Value = @"CREDIT_NOT_PROCESSED")]
        CREDIT_NOT_PROCESSED = 16,

        [EnumMember(Value = @"NON_RECEIPT_OF_CASH_OR_LOAD_TRANSACTION_VALUE_AT_ATM")]
        NON_RECEIPT_OF_CASH_OR_LOAD_TRANSACTION_VALUE_AT_ATM = 17
    }
}