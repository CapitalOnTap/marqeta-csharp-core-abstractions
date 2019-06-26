namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IFinancialClient
    {
        /// <summary>Simulates a financial advice transaction</summary>
        /// <param name="body">Financial advice request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> AdviceAsync(Authorization_advice_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates a financial advice transaction</summary>
        /// <param name="body">Financial advice request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> AdviceAsync(Authorization_advice_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Simulates a balance inquiry</summary>
        /// <param name="body">Balance inquiry request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> BalanceinquiryAsync(Balance_inquiry_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates a balance inquiry</summary>
        /// <param name="body">Balance inquiry request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> BalanceinquiryAsync(Balance_inquiry_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Simulates an ATM withdrawal transaction</summary>
        /// <param name="body">ATM withdrawal request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> WithdrawalAsync(Withdrawal_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulates an ATM withdrawal transaction</summary>
        /// <param name="body">ATM withdrawal request model</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Simulation_response_model> WithdrawalAsync(Withdrawal_request_model body, System.Threading.CancellationToken cancellationToken);
    
    }
}