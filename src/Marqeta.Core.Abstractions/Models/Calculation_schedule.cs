using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Calculation_schedule
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Calculation_scheduleValue_type? Value_type { get; set; } = Calculation_scheduleValue_type.PERCENT;

        [JsonProperty("name", Required = Required.Always)]
        [Required]
        [StringLength(32, MinimumLength = 1)]
        public string Name { get; set; }

        [JsonProperty("steps", Required = Required.Always)]
        [Required]
        public ICollection<double> Steps { get; set; } = new Collection<double>();

        [JsonProperty("step_values", Required = Required.Always)]
        [Required]
        public ICollection<double> Step_values { get; set; } = new Collection<double>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}