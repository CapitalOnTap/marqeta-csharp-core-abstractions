using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Base_ach_extended_response_model
    {
        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        [JsonProperty("account_suffix", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_suffix { get; set; }

        [JsonProperty("verification_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Verification_status { get; set; }

        [JsonProperty("account_type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Account_type { get; set; }

        [JsonProperty("name_on_account", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Name_on_account { get; set; }

        [JsonProperty("bank_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bank_name { get; set; }

        [JsonProperty("active", Required = Required.Always)]
        public bool Active { get; set; }

        [JsonProperty("date_sent_for_verification", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_sent_for_verification { get; set; }

        [JsonProperty("is_default_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_default_account { get; set; } = false;

        [JsonProperty("date_verified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_verified { get; set; }

        [JsonProperty("verification_override", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verification_override { get; set; } = false;

        [JsonProperty("verification_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Verification_notes { get; set; }

        [JsonProperty("routing_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Routing_number { get; set; }

        [JsonProperty("account_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Account_number { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}