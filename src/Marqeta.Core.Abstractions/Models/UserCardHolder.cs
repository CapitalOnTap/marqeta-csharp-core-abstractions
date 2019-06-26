﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserCardHolder
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("realId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RealId { get; set; }

        [JsonProperty("uuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        [JsonProperty("searchPath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchPath { get; set; }

        [JsonProperty("deals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DealLog> Deals { get; set; }

        [JsonProperty("cardholderAddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CardholderAddress> CardholderAddresses { get; set; }

        [JsonProperty("parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardHolder Parent { get; set; }

        [JsonProperty("kid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kid { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("passwordSalt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordSalt { get; set; }

        [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("accounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Accounts { get; set; }

        [JsonProperty("cards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Card> Cards { get; set; }

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("issuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Issuer Issuer { get; set; }

        [JsonProperty("ipAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("idempotentHash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdempotentHash { get; set; }

        [JsonProperty("accountHolderGroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AccountHolderGroup AccountHolderGroup { get; set; }

        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Metadata { get; set; }

        [JsonProperty("depositAccounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DepositAccount> DepositAccounts { get; set; }

        [JsonProperty("cardHolderAttributes", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CardHolderAttribute> CardHolderAttributes { get; set; }

        [JsonProperty("superInactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SuperInactive { get; set; } = false;

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserCardHolderStatus? Status { get; set; }

        [JsonProperty("emailVerified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailVerified { get; set; } = false;

        [JsonProperty("emailVerifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EmailVerifiedTime { get; set; }

        [JsonProperty("honorific", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Honorific { get; set; }

        [JsonProperty("gender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [JsonProperty("firstName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("middleName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        [JsonProperty("lastName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("address1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address1 { get; set; }

        [JsonProperty("address2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address2 { get; set; }

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("birthDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BirthDate { get; set; }

        [JsonProperty("ssn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ssn { get; set; }

        [JsonProperty("ssnHash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SsnHash { get; set; }

        [JsonProperty("lastFourSSNHash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastFourSSNHash { get; set; }

        [JsonProperty("ssnType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserCardHolderSsnType? SsnType { get; set; }

        [JsonProperty("identity1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<byte[]> Identity1 { get; set; }

        [JsonProperty("corporateCardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CorporateCardHolder { get; set; } = false;

        [JsonProperty("passportNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PassportNumber { get; set; }

        [JsonProperty("passportExpirationDate", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PassportExpirationDate { get; set; }

        [JsonProperty("idCardNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardNumber { get; set; }

        [JsonProperty("idCardExpirationDate", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IdCardExpirationDate { get; set; }

        [JsonProperty("nationality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        [JsonProperty("company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        [JsonProperty("usesParentAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsesParentAccount { get; set; } = false;

        [JsonProperty("defaultFundingAddress", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public CardholderAddress DefaultFundingAddress { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}