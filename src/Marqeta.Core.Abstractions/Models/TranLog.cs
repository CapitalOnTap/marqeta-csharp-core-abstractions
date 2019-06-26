using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class TranLog
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("localId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? LocalId { get; set; }

        [JsonProperty("tranlogToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranlogToken TranlogToken { get; set; }

        [JsonProperty("node", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Node { get; set; }

        [JsonProperty("network", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Network { get; set; }

        [JsonProperty("subNetwork", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SubNetwork { get; set; }

        [JsonProperty("acquirer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Acquirer { get; set; }

        [JsonProperty("originator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Originator { get; set; }

        [JsonProperty("forwardingInstId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ForwardingInstId { get; set; }

        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        [JsonProperty("networkMid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkMid { get; set; }

        [JsonProperty("tid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("stan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Stan { get; set; }

        [JsonProperty("responseCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseCode { get; set; }

        [JsonProperty("approvalNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalNumber { get; set; }

        [JsonProperty("displayMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayMessage { get; set; }

        [JsonProperty("currencyCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }

        [JsonProperty("mcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        [JsonProperty("functionCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionCode { get; set; }

        [JsonProperty("reasonCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        [JsonProperty("fileName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("reversalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReversalId { get; set; }

        [JsonProperty("reversalCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReversalCount { get; set; }

        [JsonProperty("completionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletionId { get; set; }

        [JsonProperty("completionCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletionCount { get; set; }

        [JsonProperty("voidId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? VoidId { get; set; }

        [JsonProperty("voidCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VoidCount { get; set; }

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("transmissionDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransmissionDate { get; set; }

        [JsonProperty("localTransactionDate", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LocalTransactionDate { get; set; }

        [JsonProperty("captureDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CaptureDate { get; set; }

        [JsonProperty("settlementDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SettlementDate { get; set; }

        [JsonProperty("batchNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BatchNumber { get; set; }

        [JsonProperty("networkReferenceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkReferenceId { get; set; }

        [JsonProperty("acquirerReferenceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerReferenceId { get; set; }

        [JsonProperty("retrievalReferenceNumber", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string RetrievalReferenceNumber { get; set; }

        [JsonProperty("incomingNetworkRequestITC", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string IncomingNetworkRequestITC { get; set; }

        [JsonProperty("itc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Itc { get; set; }

        [JsonProperty("originalItc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalItc { get; set; }

        [JsonProperty("irc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Irc { get; set; }

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("requestAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RequestAmount { get; set; }

        [JsonProperty("additionalAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AdditionalAmount { get; set; }

        [JsonProperty("responseAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ResponseAmount { get; set; }

        [JsonProperty("acquirerFee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AcquirerFee { get; set; }

        [JsonProperty("issuerFee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IssuerFee { get; set; }

        [JsonProperty("returnedBalances", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnedBalances { get; set; }

        [JsonProperty("rc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Rc { get; set; }

        [JsonProperty("extrc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Extrc { get; set; }

        [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        [JsonProperty("outstanding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Outstanding { get; set; }

        [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<byte[]> Request { get; set; }

        [JsonProperty("response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<byte[]> Response { get; set; }

        [JsonProperty("refId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLog RefId { get; set; }

        [JsonProperty("cardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardHolder CardHolder { get; set; }

        [JsonProperty("actingCardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardHolder ActingCardHolder { get; set; }

        [JsonProperty("card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Card Card { get; set; }

        [JsonProperty("account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Account Account { get; set; }

        [JsonProperty("account2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Account Account2 { get; set; }

        [JsonProperty("glTransaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GLTransaction GlTransaction { get; set; }

        [JsonProperty("cardAcceptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardAcceptor CardAcceptor { get; set; }

        [JsonProperty("remoteHost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteHost { get; set; }

        [JsonProperty("followUps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> FollowUps { get; set; }

        [JsonProperty("posDataCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PosDataCode { get; set; }

        [JsonProperty("committedUsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CommittedUsed { get; set; }

        [JsonProperty("feeRate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FeeRate { get; set; }

        [JsonProperty("gatewaylog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Gatewaylog Gatewaylog { get; set; }

        [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Attributes { get; set; }

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        [JsonProperty("transactionState", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TranLogTransactionState? TransactionState { get; set; }

        [JsonProperty("completion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLog Completion { get; set; }

        [JsonProperty("expirationTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpirationTime { get; set; }

        [JsonProperty("multiClearCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MultiClearCount { get; set; }

        [JsonProperty("releaseRemainingAmountOnHold", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReleaseRemainingAmountOnHold { get; set; } = false;

        [JsonProperty("adviceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AdviceId { get; set; }

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonProperty("digitalWalletToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DigitalWalletToken DigitalWalletToken { get; set; }

        [JsonProperty("userTransactionTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UserTransactionTime { get; set; }

        [JsonProperty("tranLogAssociation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLogAssociation TranLogAssociation { get; set; }

        [JsonProperty("rootReference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLog RootReference { get; set; }

        [JsonProperty("approved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approved { get; set; } = false;

        [JsonProperty("purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Purchase { get; set; } = false;

        [JsonProperty("withdrawal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Withdrawal { get; set; } = false;

        [JsonProperty("cashBack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CashBack { get; set; } = false;

        [JsonProperty("transfer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Transfer { get; set; } = false;

        [JsonProperty("itcShort", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ItcShort { get; set; }

        [JsonProperty("contributionAmounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, double> ContributionAmounts { get; set; }

        [JsonProperty("statusAsString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string StatusAsString { get; set; }

        [JsonProperty("achPostingOrReversal", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? AchPostingOrReversal { get; set; } = false;

        [JsonProperty("cardHolderObligation", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? CardHolderObligation { get; set; }

        [JsonProperty("amountIncrease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AmountIncrease { get; set; }

        [JsonProperty("amountPlusAcquirerFee", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? AmountPlusAcquirerFee { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}