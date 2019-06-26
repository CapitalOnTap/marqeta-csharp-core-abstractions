namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface ICardsClient
    {
        /// <summary>get</summary>
        /// <param name="barcode">Barcode</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> BarcodeAsync(string barcode, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>get</summary>
        /// <param name="barcode">Barcode</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> BarcodeAsync(string barcode, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns the user and card tokens for specified PAN</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Pan_response> GetbypanAsync(Pan_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns the user and card tokens for specified PAN</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Pan_response> GetbypanAsync(Pan_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a merchant onboarding card</summary>
        /// <param name="merchant_token">Merchant token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> MerchantGetAsync(string merchant_token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a merchant onboarding card</summary>
        /// <param name="merchant_token">Merchant token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> MerchantGetAsync(string merchant_token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a merchant onboarding card</summary>
        /// <param name="merchant_token">Merchant token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> MerchantPostAsync(string merchant_token, Merchant_card_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a merchant onboarding card</summary>
        /// <param name="merchant_token">Merchant token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> MerchantPostAsync(string merchant_token, Merchant_card_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all cards for one user</summary>
        /// <param name="token">User token</param>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> UserAsync(string token, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all cards for one user</summary>
        /// <param name="token">User token</param>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> UserAsync(string token, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific card - PAN visible</summary>
        /// <param name="token">Card token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> ShowpanAsync(string token, string fields, bool? show_cvv_number);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific card - PAN visible</summary>
        /// <param name="token">Card token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> ShowpanAsync(string token, string fields, bool? show_cvv_number, System.Threading.CancellationToken cancellationToken);
    
    }
}