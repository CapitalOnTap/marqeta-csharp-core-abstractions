namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IWebhooksClient
    {
        /// <summary>Ping a webhook</summary>
        /// <param name="token">Ping a webhook</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_ping_model> PingAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Ping a webhook</summary>
        /// <param name="token">Ping a webhook</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_ping_model> PingAsync(string token, System.Threading.CancellationToken cancellationToken);
    
    }
}