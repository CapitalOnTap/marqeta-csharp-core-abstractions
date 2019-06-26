using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Airline
    {
        [JsonProperty("passenger_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Passenger_name { get; set; }

        [JsonProperty("depart_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Depart_date { get; set; }

        [JsonProperty("origination_city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Origination_city { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}