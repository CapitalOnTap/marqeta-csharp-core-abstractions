namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IBalancesClient
    {
        /// <summary>Retrieve a merchant-specific account balance</summary>
        /// <param name="token">User of Business token</param>
        /// <param name="count">Number of restrictions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_msa_balance> MsasAsync(string token, int? count, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a merchant-specific account balance</summary>
        /// <param name="token">User of Business token</param>
        /// <param name="count">Number of restrictions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_msa_balance> MsasAsync(string token, int? count, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
    }
}