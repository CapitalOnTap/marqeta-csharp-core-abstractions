namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IProgramreserveClient
    {
        /// <summary>Returns the latest amount in the Program Reserve account</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_reserve_account_balance> BalancesAsync();
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns the latest amount in the Program Reserve account</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_reserve_account_balance> BalancesAsync(System.Threading.CancellationToken cancellationToken);
    
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task DepositsGetAsync(int? count, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task DepositsGetAsync(int? count, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task DepositsPostAsync(Program_reserve_deposit_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task DepositsPostAsync(Program_reserve_deposit_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a list of Program Reserve Transactions (Credits and Debits)</summary>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="body">type</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_reserve_transaction_response> TransactionsGetAsync(int? count, int? start_index, string sort_by, string body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a list of Program Reserve Transactions (Credits and Debits)</summary>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="body">type</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_reserve_transaction_response> TransactionsGetAsync(int? count, int? start_index, string sort_by, string body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Credits or Debits the Program Reserve account</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_reserve_transaction_response> TransactionsPostAsync(Program_reserve_transaction_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Credits or Debits the Program Reserve account</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_reserve_transaction_response> TransactionsPostAsync(Program_reserve_transaction_request body, System.Threading.CancellationToken cancellationToken);
    
    }
}