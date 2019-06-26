using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class DepositAccount
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("cardHolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CardHolder CardHolder { get; set; }

        [JsonProperty("accountNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<byte[]> AccountNumber { get; set; }

        [JsonProperty("routingNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RoutingNumber { get; set; }

        [JsonProperty("hashedAccountNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HashedAccountNumber { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("kid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kid { get; set; }

        [JsonProperty("allowImmediateCredit", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowImmediateCredit { get; set; } = false;

        [JsonProperty("createdTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("lastModifiedTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}