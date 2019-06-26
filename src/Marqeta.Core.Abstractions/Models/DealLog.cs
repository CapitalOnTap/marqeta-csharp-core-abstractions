using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DealLog
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created { get; set; }

        [JsonProperty("completed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Completed { get; set; }

        [JsonProperty("dealDescriptor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DealDescriptor DealDescriptor { get; set; }

        [JsonProperty("cardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardHolder CardHolder { get; set; }

        [JsonProperty("account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount Account { get; set; }

        [JsonProperty("recipientState", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RecipientState { get; set; }

        [JsonProperty("paymentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentId { get; set; }

        [JsonProperty("promotionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionId { get; set; }

        [JsonProperty("fundingSourceToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FundingSourceToken { get; set; }

        [JsonProperty("fundingSourceAddress", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public CardholderAddress FundingSourceAddress { get; set; }

        [JsonProperty("entries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GLEntry> Entries { get; set; }

        [JsonProperty("orderType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DealLogOrderType? OrderType { get; set; }

        [JsonProperty("originalOrder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DealLog OriginalOrder { get; set; }

        [JsonProperty("tranLog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TranLog TranLog { get; set; }

        [JsonProperty("additionalRef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalRef { get; set; }

        [JsonProperty("pristine", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pristine { get; set; } = false;

        [JsonProperty("lastTransactionDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastTransactionDate { get; set; }

        [JsonProperty("shortCurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ShortCurrency { get; set; }

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}