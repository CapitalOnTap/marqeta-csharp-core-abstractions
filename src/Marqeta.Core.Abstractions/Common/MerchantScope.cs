using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions.Common
{
    public class MerchantScope
    {
        [JsonProperty("mid")] public string Mid { get; set; }

        [JsonProperty("mcc")] public string Mcc { get; set; }

        [JsonProperty("mcc_group")] public string MccGroup { get; set; }
    }
}