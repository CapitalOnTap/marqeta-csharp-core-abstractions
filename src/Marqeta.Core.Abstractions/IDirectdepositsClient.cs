namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IDirectdepositsClient
    {
        /// <summary>Returns an account and routing number which can be used for direct deposit</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Deposit_account> AccountsGetAsync(string user_or_business_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns an account and routing number which can be used for direct deposit</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Deposit_account> AccountsGetAsync(string user_or_business_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Update a direct deposit account</summary>
        /// <param name="user_or_business_token">User or Business Token</param>
        /// <param name="body">Deposit Account Update Request</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Deposit_account> AccountsPutAsync(string user_or_business_token, Deposit_account_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a direct deposit account</summary>
        /// <param name="user_or_business_token">User or Business Token</param>
        /// <param name="body">Deposit Account Update Request</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Deposit_account> AccountsPutAsync(string user_or_business_token, Deposit_account_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a list if direct deposit transitions</summary>
        /// <param name="count">Number of direct deposit transitions to retrieve</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="direct_deposit_token">Direct deposit token</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="states">A comma delimited list of direct deposit state(s) to display e.g. PENDING | REVERSED | APPLIED | REJECTED</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<DirectDepositTransitionResponse>> TransitionsGetAsync(int? count, string user_token, string business_token, string direct_deposit_token, int? start_index, string sort_by, string states);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a list if direct deposit transitions</summary>
        /// <param name="count">Number of direct deposit transitions to retrieve</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="direct_deposit_token">Direct deposit token</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="states">A comma delimited list of direct deposit state(s) to display e.g. PENDING | REVERSED | APPLIED | REJECTED</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<DirectDepositTransitionResponse>> TransitionsGetAsync(int? count, string user_token, string business_token, string direct_deposit_token, int? start_index, string sort_by, string states, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create a direct deposit transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DirectDepositTransitionResponse> TransitionsPostAsync(DirectDepositTransitionRequest body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a direct deposit transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DirectDepositTransitionResponse> TransitionsPostAsync(DirectDepositTransitionRequest body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a direct deposit transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DirectDepositTransitionResponse> TransitionsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a direct deposit transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DirectDepositTransitionResponse> TransitionsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
    }
}