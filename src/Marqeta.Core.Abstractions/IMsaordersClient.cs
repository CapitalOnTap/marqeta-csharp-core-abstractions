namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IMsaordersClient
    {
        /// <summary>List all MSA unloads</summary>
        /// <param name="count">Number of gpa unloads to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="original_order_token">Original order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Msa_returns>> UnloadsGetAsync(int? count, int? start_index, string sort_by, string user_token, string business_token, string original_order_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all MSA unloads</summary>
        /// <param name="count">Number of gpa unloads to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="original_order_token">Original order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Msa_returns>> UnloadsGetAsync(int? count, int? start_index, string sort_by, string user_token, string business_token, string original_order_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Return a msa order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_returns> UnloadsPostAsync(Msa_unload_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return a msa order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_returns> UnloadsPostAsync(Msa_unload_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific MSA unload</summary>
        /// <param name="unload_token">Unload token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_returns> UnloadsGetAsync(string unload_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific MSA unload</summary>
        /// <param name="unload_token">Unload token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_returns> UnloadsGetAsync(string unload_token, System.Threading.CancellationToken cancellationToken);
    
    }
}