namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IMerchantClient
    {
        /// <summary>Returns a specific card - PAN visible</summary>
        /// <param name="merchant_token">Merchant token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> ShowpanAsync(string merchant_token, string fields, bool? show_cvv_number);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific card - PAN visible</summary>
        /// <param name="merchant_token">Merchant token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> ShowpanAsync(string merchant_token, string fields, bool? show_cvv_number, System.Threading.CancellationToken cancellationToken);
    
    }
}