using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions.MccGroups
{
    public class Config
    {
        [JsonProperty("authorization_controls")]
        public AuthorizationControls AuthorizationControls { get; set; }
    }
}