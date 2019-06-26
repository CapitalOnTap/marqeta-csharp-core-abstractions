namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IAchClient
    {
        /// <summary>Returns the dollar amounts used to verify the ACH account</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Ach_verification_model>> VerificationamountsAsync(string funding_source_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns the dollar amounts used to verify the ACH account</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Ach_verification_model>> VerificationamountsAsync(string funding_source_token, System.Threading.CancellationToken cancellationToken);
    
    }
}