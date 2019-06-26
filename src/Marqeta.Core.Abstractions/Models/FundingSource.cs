using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class FundingSource
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("alias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        [JsonProperty("defaultSource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSource { get; set; } = false;

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("debitAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Account DebitAccount { get; set; }

        [JsonProperty("creditAccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Account CreditAccount { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("fundingSourceAttributes", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> FundingSourceAttributes { get; set; }

        [JsonProperty("fromCardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FromCardHolder { get; set; } = false;

        [JsonProperty("internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Internal { get; set; } = false;

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}