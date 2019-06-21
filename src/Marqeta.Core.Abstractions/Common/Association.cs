using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions.Common
{
    public class Association
    {
        [JsonProperty("card_product_token ")]
        public string CardProductToken { get; set; }

        [JsonProperty("user_token")]
        public string UserToken { get; set; }
    }
}
