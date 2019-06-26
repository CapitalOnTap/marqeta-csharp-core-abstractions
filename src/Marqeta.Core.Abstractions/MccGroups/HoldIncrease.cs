using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions.MccGroups
{
    public class HoldIncrease
    {
        public enum HoldType
        {
            Amount,
            Percent
        }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HoldType Type { get; set; }

        [JsonProperty("value")] public long Value { get; set; }
    }
}