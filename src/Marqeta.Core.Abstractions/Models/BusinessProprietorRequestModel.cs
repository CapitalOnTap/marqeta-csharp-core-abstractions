using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BusinessProprietorRequestModel
    {
        [JsonProperty("first_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string First_name { get; set; }

        [JsonProperty("middle_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Middle_name { get; set; }

        [JsonProperty("last_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Last_name { get; set; }

        [JsonProperty("alternative_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Alternative_names { get; set; }

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("home", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressRequestModel Home { get; set; }

        [JsonProperty("ssn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ssn { get; set; }

        [JsonProperty("dob", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dob { get; set; }

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("identifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IdentificationRequestModel> Identifications { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}