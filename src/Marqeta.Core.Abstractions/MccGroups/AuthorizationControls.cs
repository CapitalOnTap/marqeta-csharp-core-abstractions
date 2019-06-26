using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions.MccGroups
{
    public class AuthorizationControls
    {
        [JsonProperty("hold_increase")] public HoldIncrease HoldIncrease { get; set; }

        [JsonProperty("hold_expiration_days")] public long HoldExpirationDays { get; set; }
    }
}