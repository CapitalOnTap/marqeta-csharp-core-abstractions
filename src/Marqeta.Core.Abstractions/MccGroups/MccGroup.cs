using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions.MccGroups
{
    public class MccGroup
    {
        [JsonProperty("token")] public string Token { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("mccs")] public string[] Mccs { get; set; }

        [JsonProperty("active")] public bool Active { get; set; }

        [JsonProperty("config")] public Config Config { get; set; }
    }
}