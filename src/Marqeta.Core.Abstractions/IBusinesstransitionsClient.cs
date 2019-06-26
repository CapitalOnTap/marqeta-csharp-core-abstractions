namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IBusinesstransitionsClient
    {
        /// <summary>Retrieve transitions for a given business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="count">Number of business transitions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BusinessTransitionResponse>> BusinessAsync(string business_token, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve transitions for a given business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="count">Number of business transitions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BusinessTransitionResponse>> BusinessAsync(string business_token, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
    }
}