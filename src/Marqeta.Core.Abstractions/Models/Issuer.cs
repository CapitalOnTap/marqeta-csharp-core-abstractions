using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Issuer
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("tz", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tz { get; set; }

        [JsonProperty("endDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("journal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Journal Journal { get; set; }

        [JsonProperty("account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Account Account { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("cardHolders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CardHolder> CardHolders { get; set; }

        [JsonProperty("cardProducts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Card_product> CardProducts { get; set; }

        [JsonProperty("acquirers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Acquirer2> Acquirers { get; set; }

        [JsonProperty("partnerMFDAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount PartnerMFDAccount { get; set; }

        [JsonProperty("programMFDFeeAccount", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount ProgramMFDFeeAccount { get; set; }

        [JsonProperty("directDepositRoutingNumber", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string DirectDepositRoutingNumber { get; set; }

        [JsonProperty("directDepositAccountPrefix", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string DirectDepositAccountPrefix { get; set; }

        [JsonProperty("mfdfeeCalculationSchedule", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public CalculationSchedule MfdfeeCalculationSchedule { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}