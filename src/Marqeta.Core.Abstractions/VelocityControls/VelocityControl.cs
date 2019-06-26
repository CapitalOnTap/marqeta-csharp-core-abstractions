using Marqeta.Core.Abstractions.Common;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions.VelocityControls
{
    public class VelocityControl
    {
        [JsonProperty("token")] public string Token { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("amount_limit")] public long AmountLimit { get; set; }

        [JsonProperty("usage_limit")] public long UsageLimit { get; set; }

        [JsonProperty("velocity_window")] public VelocityWindow VelocityWindow { get; set; }

        [JsonProperty("approvals_only")] public bool ApprovalsOnly { get; set; }

        [JsonProperty("include_purchases")] public bool IncludePurchases { get; set; }

        [JsonProperty("include_withdrawals")] public bool IncludeWithdrawals { get; set; }

        [JsonProperty("include_transfers")] public bool IncludeTransfers { get; set; }

        [JsonProperty("include_cashback")] public bool IncludeCashback { get; set; }

        [JsonProperty("include_credits")] public bool IncludeCredits { get; set; }

        [JsonProperty("currency_code")] public string CurrencyCode { get; set; }

        [JsonProperty("active")] public bool Active { get; set; }

        [JsonProperty("association")] public Association Association { get; set; }

        [JsonProperty("merchant_scope")] public MerchantScope MerchantScope { get; set; }
    }
}