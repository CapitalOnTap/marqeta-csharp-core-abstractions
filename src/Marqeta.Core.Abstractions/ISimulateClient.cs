namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface ISimulateClient
    {
        /// <summary>Simulates an Authorization</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> AuthorizationAsync(Auth_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates an Authorization</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> AuthorizationAsync(Auth_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Simulates a clearing/settlement transaction</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> ClearingAsync(ClearingModel body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates a clearing/settlement transaction</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> ClearingAsync(ClearingModel body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Simulates the creation of direct deposit</summary>
        /// <param name="body">Direct deposit simulate request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DepositDepositResponse> DirectdepositsAsync(DirectDepositRequest body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates the creation of direct deposit</summary>
        /// <param name="body">Direct deposit simulate request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DepositDepositResponse> DirectdepositsAsync(DirectDepositRequest body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Simulates a financial request (pindebit) transaction with optional cash back</summary>
        /// <param name="body">Financial request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> FinancialAsync(Financial_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates a financial request (pindebit) transaction with optional cash back</summary>
        /// <param name="body">Financial request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> FinancialAsync(Financial_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Simulates a reversal transaction</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> ReversalAsync(ReversalModel body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates a reversal transaction</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> ReversalAsync(ReversalModel body, System.Threading.CancellationToken cancellationToken);
    
    }
}