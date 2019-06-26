using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Cron_job_info
    {
        [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Schedule { get; set; }

        [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        [JsonProperty("is_running", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_running { get; set; } = false;

        [JsonProperty("last_run_duration_millis", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public long? Last_run_duration_millis { get; set; }

        [JsonProperty("next_run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Next_run { get; set; }

        [JsonProperty("last_run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_run { get; set; }

        [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        [JsonProperty("start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}