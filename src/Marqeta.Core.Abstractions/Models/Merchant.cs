using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Merchant
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } = false;

        [JsonProperty("contact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        [JsonProperty("contactEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmail { get; set; }

        [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [JsonProperty("address1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address1 { get; set; }

        [JsonProperty("address2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address2 { get; set; }

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("province", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("partialAuthFlag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PartialAuthFlag { get; set; } = false;

        [JsonProperty("externalInfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> ExternalInfo { get; set; }

        [JsonProperty("stores", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> Stores { get; set; }

        [JsonProperty("terminals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> Terminals { get; set; }

        [JsonProperty("acquirer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Acquirer2 Acquirer { get; set; }

        [JsonProperty("campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Campaign Campaign { get; set; }

        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        [JsonProperty("networkMid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkMid { get; set; }

        [JsonProperty("merchantToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantToken { get; set; }

        [JsonProperty("partialApprovalCapable", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? PartialApprovalCapable { get; set; } = false;

        [JsonProperty("keyedAuthCvvEnforced", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? KeyedAuthCvvEnforced { get; set; } = false;

        [JsonProperty("created_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}