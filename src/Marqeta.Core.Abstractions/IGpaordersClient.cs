namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IGpaordersClient
    {
        /// <summary>List all gpa returns</summary>
        /// <param name="count">Number of gpa unloads to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="original_order_token">Original order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Gpa_returns>> UnloadsGetAsync(int? count, int? start_index, string fields, string sort_by, string user_token, string business_token, string original_order_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all gpa returns</summary>
        /// <param name="count">Number of gpa unloads to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="original_order_token">Original order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Gpa_returns>> UnloadsGetAsync(int? count, int? start_index, string fields, string sort_by, string user_token, string business_token, string original_order_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Return a gpa order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_returns> UnloadsPostAsync(Unload_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return a gpa order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_returns> UnloadsPostAsync(Unload_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific return</summary>
        /// <param name="unload_token">Unload token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_returns> UnloadsGetAsync(string unload_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific return</summary>
        /// <param name="unload_token">Unload token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_returns> UnloadsGetAsync(string unload_token, System.Threading.CancellationToken cancellationToken);
    
    }
}