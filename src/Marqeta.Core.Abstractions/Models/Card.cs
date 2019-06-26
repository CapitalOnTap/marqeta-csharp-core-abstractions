using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Card
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("bin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bin { get; set; }

        [JsonProperty("lastFour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastFour { get; set; }

        [JsonProperty("kid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kid { get; set; }

        [JsonProperty("hash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("secureData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<byte[]> SecureData { get; set; }

        [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("cardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UserCardHolder CardHolder { get; set; }

        [JsonProperty("cardProduct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_product CardProduct { get; set; }

        [JsonProperty("fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, double> Fees { get; set; }

        [JsonProperty("merchant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Merchant Merchant { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("idempotentHash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdempotentHash { get; set; }

        [JsonProperty("pan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pan { get; set; }

        [JsonProperty("encryptedPAN", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CryptoData EncryptedPAN { get; set; }

        [JsonProperty("encryptedPIN", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CryptoData EncryptedPIN { get; set; }

        [JsonProperty("encryptedCVV", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CryptoData EncryptedCVV { get; set; }

        [JsonProperty("encryptedMSCVV", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CryptoData EncryptedMSCVV { get; set; }

        [JsonProperty("encryptedICVV", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CryptoData EncryptedICVV { get; set; }

        [JsonProperty("barcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Barcode { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardState? State { get; set; }

        [JsonProperty("fulfillmentStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardFulfillmentStatus? FulfillmentStatus { get; set; }

        [JsonProperty("stateReason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string StateReason { get; set; }

        [JsonProperty("returnAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FulfillmentAddress ReturnAddress { get; set; }

        [JsonProperty("recipientAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FulfillmentAddress RecipientAddress { get; set; }

        [JsonProperty("shippingMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardShippingMethod? ShippingMethod { get; set; }

        [JsonProperty("careOfLine", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CareOfLine { get; set; }

        [JsonProperty("cardPersonalization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card_personalization CardPersonalization { get; set; }

        [JsonProperty("nameLine1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NameLine1 { get; set; }

        [JsonProperty("nameLine2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NameLine2 { get; set; }

        [JsonProperty("trackName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TrackName { get; set; }

        [JsonProperty("bulkCardOrder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BulkCardOrder BulkCardOrder { get; set; }

        [JsonProperty("panGenerationSeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PanGenerationSeed { get; set; }

        [JsonProperty("serviceCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceCode { get; set; }

        [JsonProperty("terminateReIssuedSourceCard", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? TerminateReIssuedSourceCard { get; set; } = false;

        [JsonProperty("paymentInstrument", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardPaymentInstrument? PaymentInstrument { get; set; }

        [JsonProperty("replicateFromCard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card ReplicateFromCard { get; set; }

        [JsonProperty("translatePinFromCard", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Card TranslatePinFromCard { get; set; }

        [JsonProperty("swapDigitalWalletTokenFromCard", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Card SwapDigitalWalletTokenFromCard { get; set; }

        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Metadata { get; set; }

        [JsonProperty("cardAttributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CardAttribute> CardAttributes { get; set; }

        [JsonProperty("expedite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;

        [JsonProperty("expirationOffsetValue", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpirationOffsetValue { get; set; }

        [JsonProperty("expirationOffsetUnit", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardExpirationOffsetUnit? ExpirationOffsetUnit { get; set; }

        [JsonProperty("superInactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SuperInactive { get; set; } = false;

        [JsonProperty("offlinePinSetRequiredOnNextTransaction", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? OfflinePinSetRequiredOnNextTransaction { get; set; } = false;

        [JsonProperty("cardFulfillmentReason", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardFulfillmentReason? CardFulfillmentReason { get; set; }

        [JsonProperty("entityName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EntityName { get; set; }

        [JsonProperty("entityId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? EntityId { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}