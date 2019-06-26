namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Card 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bin { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastFour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastFour { get; set; }
    
        [Newtonsoft.Json.JsonProperty("kid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hash { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secureData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<byte[]> SecureData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardHolder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserCardHolder CardHolder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardProduct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_product CardProduct { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, double> Fees { get; set; }
    
        [Newtonsoft.Json.JsonProperty("merchant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Merchant Merchant { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastModifiedTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastModifiedTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("createdTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CreatedTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("idempotentHash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdempotentHash { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("encryptedPAN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CryptoData EncryptedPAN { get; set; }
    
        [Newtonsoft.Json.JsonProperty("encryptedPIN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CryptoData EncryptedPIN { get; set; }
    
        [Newtonsoft.Json.JsonProperty("encryptedCVV", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CryptoData EncryptedCVV { get; set; }
    
        [Newtonsoft.Json.JsonProperty("encryptedMSCVV", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CryptoData EncryptedMSCVV { get; set; }
    
        [Newtonsoft.Json.JsonProperty("encryptedICVV", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CryptoData EncryptedICVV { get; set; }
    
        [Newtonsoft.Json.JsonProperty("barcode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Barcode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardState? State { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fulfillmentStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardFulfillmentStatus? FulfillmentStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stateReason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StateReason { get; set; }
    
        [Newtonsoft.Json.JsonProperty("returnAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FulfillmentAddress ReturnAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("recipientAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FulfillmentAddress RecipientAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shippingMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardShippingMethod? ShippingMethod { get; set; }
    
        [Newtonsoft.Json.JsonProperty("careOfLine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CareOfLine { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardPersonalization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card_personalization CardPersonalization { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nameLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NameLine1 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nameLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NameLine2 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("trackName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TrackName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bulkCardOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BulkCardOrder BulkCardOrder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("panGenerationSeed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PanGenerationSeed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("serviceCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServiceCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("terminateReIssuedSourceCard", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? TerminateReIssuedSourceCard { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("paymentInstrument", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardPaymentInstrument? PaymentInstrument { get; set; }
    
        [Newtonsoft.Json.JsonProperty("replicateFromCard", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card ReplicateFromCard { get; set; }
    
        [Newtonsoft.Json.JsonProperty("translatePinFromCard", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card TranslatePinFromCard { get; set; }
    
        [Newtonsoft.Json.JsonProperty("swapDigitalWalletTokenFromCard", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card SwapDigitalWalletTokenFromCard { get; set; }
    
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardAttributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CardAttribute> CardAttributes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expedite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Expedite { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("expirationOffsetValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ExpirationOffsetValue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expirationOffsetUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardExpirationOffsetUnit? ExpirationOffsetUnit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("superInactive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SuperInactive { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("offlinePinSetRequiredOnNextTransaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OfflinePinSetRequiredOnNextTransaction { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("cardFulfillmentReason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardFulfillmentReason? CardFulfillmentReason { get; set; }
    
        [Newtonsoft.Json.JsonProperty("entityName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EntityName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("entityId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? EntityId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}