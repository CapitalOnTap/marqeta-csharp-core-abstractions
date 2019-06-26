namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IDigitalwallettokensClient
    {
        /// <summary>Returns a specific digital wallet token</summary>
        /// <param name="card_token">Digital Wallet token</param>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> CardAsync(string card_token, int? count, int? start_index);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific digital wallet token</summary>
        /// <param name="card_token">Digital Wallet token</param>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> CardAsync(string card_token, int? count, int? start_index, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CheckEligibilityAsync(DigitalWalletTokenCheckEligibilityRequest body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CheckEligibilityAsync(DigitalWalletTokenCheckEligibilityRequest body, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProvisioncompleteAsync(Digital_wallet_token_activate_request body, Network2 network, string network_identifier);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProvisioncompleteAsync(Digital_wallet_token_activate_request body, Network2 network, string network_identifier, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific digital wallet token PAN visible</summary>
        /// <param name="token">Digital Wallet token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> ShowtokenpanAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific digital wallet token PAN visible</summary>
        /// <param name="token">Digital Wallet token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> ShowtokenpanAsync(string token, System.Threading.CancellationToken cancellationToken);
    
    }
}