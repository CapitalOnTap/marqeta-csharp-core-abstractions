namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IPinsClient
    {
        /// <summary>Creates a new control token for a PIN</summary>
        /// <returns>Control token created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Control_token_response> ControltokenAsync(Control_token_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new control token for a PIN</summary>
        /// <returns>Control token created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Control_token_response> ControltokenAsync(Control_token_request body, System.Threading.CancellationToken cancellationToken);
    
    }
}