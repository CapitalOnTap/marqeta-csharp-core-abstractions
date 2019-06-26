using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ReportRequest
    {
        [JsonProperty("partner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Partner { get; set; }

        [JsonProperty("report", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Report { get; set; }

        [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("sendFiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendFiles { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}