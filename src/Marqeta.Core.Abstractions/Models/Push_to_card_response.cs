using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Push_to_card_response
    {
        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("address_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
        public string Address_1 { get; set; }

        [JsonProperty("address_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 1)]
        public string Address_2 { get; set; }

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40, MinimumLength = 1)]
        public string City { get; set; }

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(2, MinimumLength = 1)]
        public string State { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(10, MinimumLength = 1)]
        public string Zip { get; set; }

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("last_four", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Last_four { get; set; }

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("fast_fund_transfer_eligible", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fast_fund_transfer_eligible { get; set; } = false;

        [JsonProperty("gambling_fund_transfer_eligible", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gambling_fund_transfer_eligible { get; set; } = false;

        [JsonProperty("name_on_card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name_on_card { get; set; }

        [JsonProperty("last_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Last_name { get; set; }

        [JsonProperty("exp_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Exp_date { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}