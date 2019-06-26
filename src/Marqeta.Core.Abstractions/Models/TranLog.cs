namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class TranLog 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("localId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LocalId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tranlogToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TranlogToken TranlogToken { get; set; }
    
        [Newtonsoft.Json.JsonProperty("node", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Node { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Network { get; set; }
    
        [Newtonsoft.Json.JsonProperty("subNetwork", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubNetwork { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Acquirer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("originator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Originator { get; set; }
    
        [Newtonsoft.Json.JsonProperty("forwardingInstId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ForwardingInstId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("networkMid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NetworkMid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Stan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("responseCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponseCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approvalNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApprovalNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("displayMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayMessage { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currencyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mcc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mcc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("functionCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FunctionCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reasonCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reversalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReversalId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reversalCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ReversalCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("completionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CompletionId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("completionCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CompletionCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("voidId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? VoidId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("voidCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? VoidCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transmissionDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransmissionDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("localTransactionDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LocalTransactionDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("captureDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CaptureDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("settlementDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SettlementDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("batchNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BatchNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("networkReferenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NetworkReferenceId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirerReferenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcquirerReferenceId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("retrievalReferenceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RetrievalReferenceNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("incomingNetworkRequestITC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IncomingNetworkRequestITC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("itc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Itc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("originalItc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginalItc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("irc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Irc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("requestAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RequestAmount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("additionalAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AdditionalAmount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("responseAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ResponseAmount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("acquirerFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcquirerFee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("issuerFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IssuerFee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("returnedBalances", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnedBalances { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Rc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("extrc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Extrc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Duration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("outstanding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Outstanding { get; set; }
    
        [Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<byte[]> Request { get; set; }
    
        [Newtonsoft.Json.JsonProperty("response", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<byte[]> Response { get; set; }
    
        [Newtonsoft.Json.JsonProperty("refId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TranLog RefId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardHolder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CardHolder CardHolder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("actingCardHolder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CardHolder ActingCardHolder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card Card { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Account Account { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Account Account2 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("glTransaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GLTransaction GlTransaction { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cardAcceptor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CardAcceptor CardAcceptor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("remoteHost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RemoteHost { get; set; }
    
        [Newtonsoft.Json.JsonProperty("followUps", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> FollowUps { get; set; }
    
        [Newtonsoft.Json.JsonProperty("posDataCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PosDataCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("committedUsed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CommittedUsed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("feeRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FeeRate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("gatewaylog", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Gatewaylog Gatewaylog { get; set; }
    
        [Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tags { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transactionState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TranLogTransactionState? TransactionState { get; set; }
    
        [Newtonsoft.Json.JsonProperty("completion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TranLog Completion { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expirationTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpirationTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("multiClearCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MultiClearCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("releaseRemainingAmountOnHold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ReleaseRemainingAmountOnHold { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("adviceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? AdviceId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("createdTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CreatedTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastModifiedTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastModifiedTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("digitalWalletToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DigitalWalletToken DigitalWalletToken { get; set; }
    
        [Newtonsoft.Json.JsonProperty("userTransactionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UserTransactionTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tranLogAssociation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TranLogAssociation TranLogAssociation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rootReference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TranLog RootReference { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approved", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Approved { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("purchase", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Purchase { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("withdrawal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Withdrawal { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("cashBack", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CashBack { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("transfer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Transfer { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("itcShort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItcShort { get; set; }
    
        [Newtonsoft.Json.JsonProperty("contributionAmounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, double> ContributionAmounts { get; set; }
    
        [Newtonsoft.Json.JsonProperty("statusAsString", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusAsString { get; set; }
    
        [Newtonsoft.Json.JsonProperty("achPostingOrReversal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AchPostingOrReversal { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("cardHolderObligation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CardHolderObligation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amountIncrease", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountIncrease { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amountPlusAcquirerFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountPlusAcquirerFee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}