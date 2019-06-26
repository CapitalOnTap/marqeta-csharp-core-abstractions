namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IChargebacksClient
    {
        /// <summary>Creates a chargeback transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_transition_response> TransitionsPostAsync(Chargeback_transition_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a chargeback transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_transition_response> TransitionsPostAsync(Chargeback_transition_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a chargeback transition</summary>
        /// <param name="token">Cargeback transition token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_transition_response> TransitionsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a chargeback transition</summary>
        /// <param name="token">Cargeback transition token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_transition_response> TransitionsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all chargeback transitions that are related to a chargeback</summary>
        /// <param name="count">Number of transitions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="chargeback_token">Chargeback token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Chargeback_transition_response>> TransitionsGetAsync(int? count, int? start_index, string sort_by, string chargeback_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all chargeback transitions that are related to a chargeback</summary>
        /// <param name="count">Number of transitions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="chargeback_token">Chargeback token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Chargeback_transition_response>> TransitionsGetAsync(int? count, int? start_index, string sort_by, string chargeback_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Grants provisional credit</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task GrantprovisionalcreditAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Grants provisional credit</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task GrantprovisionalcreditAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Reverses provisional credit</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ReverseprovisionalcreditAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Reverses provisional credit</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ReverseprovisionalcreditAsync(string token, System.Threading.CancellationToken cancellationToken);
    
    }
}