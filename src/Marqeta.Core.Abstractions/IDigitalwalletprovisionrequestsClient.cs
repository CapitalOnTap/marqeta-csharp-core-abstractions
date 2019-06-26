namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IDigitalwalletprovisionrequestsClient
    {
        /// <summary>validate and creates visa and android specific provisioning request data</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_android_pay_provision_response> AndroidpayAsync(Digital_wallet_android_pay_provision_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>validate and creates visa and android specific provisioning request data</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_android_pay_provision_response> AndroidpayAsync(Digital_wallet_android_pay_provision_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>validate apple certs and creates visa and apple specific provisioning request data</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_apple_pay_provision_response> ApplepayAsync(Digital_wallet_apple_pay_provision_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>validate apple certs and creates visa and apple specific provisioning request data</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_apple_pay_provision_response> ApplepayAsync(Digital_wallet_apple_pay_provision_request body, System.Threading.CancellationToken cancellationToken);
    
    }
}