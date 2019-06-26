using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Acquirer2
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("transactionAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount TransactionAccount { get; set; }

        [JsonProperty("feeAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount FeeAccount { get; set; }

        [JsonProperty("feeLossesAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount FeeLossesAccount { get; set; }

        [JsonProperty("feeEarningsAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount FeeEarningsAccount { get; set; }

        [JsonProperty("refundAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount RefundAccount { get; set; }

        [JsonProperty("depositAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount DepositAccount { get; set; }

        [JsonProperty("chargebackAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount ChargebackAccount { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("issuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Issuer Issuer { get; set; }

        [JsonProperty("mfdaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount Mfdaccount { get; set; }

        [JsonProperty("mfdfeeAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FinalAccount MfdfeeAccount { get; set; }

        [JsonProperty("mfdfeeCalculationSchedule", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public CalculationSchedule MfdfeeCalculationSchedule { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}