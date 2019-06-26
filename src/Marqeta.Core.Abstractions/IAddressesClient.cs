namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IAddressesClient
    {
        /// <summary>List all addresses for a business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> BusinessAsync(string business_token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all addresses for a business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> BusinessAsync(string business_token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all addresses for a user</summary>
        /// <param name="user_token">User Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> UserAsync(string user_token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all addresses for a user</summary>
        /// <param name="user_token">User Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> UserAsync(string user_token, string fields, System.Threading.CancellationToken cancellationToken);
    
    }
}