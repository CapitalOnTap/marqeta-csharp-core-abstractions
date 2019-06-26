using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DigitalWalletToken
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card Card { get; set; }

        [JsonProperty("hash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }

        [JsonProperty("secureToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<byte[]> SecureToken { get; set; }

        [JsonProperty("kid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kid { get; set; }

        [JsonProperty("tokenAssuranceLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenAssuranceLevel { get; set; }

        [JsonProperty("tokenRequestorId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenRequestorId { get; set; }

        [JsonProperty("tokenRequestorName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DigitalWalletTokenTokenRequestorName? TokenRequestorName { get; set; }

        [JsonProperty("tokenReferenceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenReferenceId { get; set; }

        [JsonProperty("tokenExpirationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TokenExpirationDate { get; set; }

        [JsonProperty("tokenType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenType { get; set; }

        [JsonProperty("tokenState", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DigitalWalletTokenTokenState? TokenState { get; set; }

        [JsonProperty("fulfillmentStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DigitalWalletTokenFulfillmentStatus? FulfillmentStatus { get; set; }

        [JsonProperty("tokenStateReason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenStateReason { get; set; }

        [JsonProperty("panReferenceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PanReferenceId { get; set; }

        [JsonProperty("tokenScore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenScore { get; set; }

        [JsonProperty("issuerEligibilityDecision", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerEligibilityDecision { get; set; }

        [JsonProperty("tokenServiceProviderEligibilityDecision", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string TokenServiceProviderEligibilityDecision { get; set; }

        [JsonProperty("numberOfActiveTokens", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfActiveTokens { get; set; }

        [JsonProperty("numberOfInactiveTokens", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfInactiveTokens { get; set; }

        [JsonProperty("numberOfSuspendedTokens", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfSuspendedTokens { get; set; }

        [JsonProperty("issuerTermsAndCondition", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerTermsAndCondition { get; set; }

        [JsonProperty("issuerTermsAndConditionDate", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuerTermsAndConditionDate { get; set; }

        [JsonProperty("correlationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationId { get; set; }

        [JsonProperty("digitalWalletTokenAttributes", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DigitalWalletTokenAttribute> DigitalWalletTokenAttributes { get; set; }

        [JsonProperty("superInactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SuperInactive { get; set; } = false;

        [JsonProperty("numberOfActivationAttempts", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfActivationAttempts { get; set; }

        [JsonProperty("digitalWalletTokenDevice", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletTokenDeviceInfo DigitalWalletTokenDevice { get; set; }

        [JsonProperty("digitalWalletTokenWalletProvider", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletTokenWalletProviderInfo DigitalWalletTokenWalletProvider { get; set; }

        [JsonProperty("digitalWalletTokenAddressVerification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletTokenAddressVerification DigitalWalletTokenAddressVerification { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}