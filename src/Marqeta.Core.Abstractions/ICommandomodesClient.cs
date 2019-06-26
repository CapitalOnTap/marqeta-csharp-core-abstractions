namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface ICommandomodesClient
    {
        /// <summary>Returns a commandomode transition</summary>
        /// <param name="token">CommandoMode transition token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Commando_mode_transition_response> TransitionsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a commandomode transition</summary>
        /// <param name="token">CommandoMode transition token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Commando_mode_transition_response> TransitionsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all commandomode transitions related to a commandomode</summary>
        /// <param name="count">Number of transitions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="commandomode_token">CommandoMode token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Commando_mode_transition_response>> TransitionsGetAsync(int? count, int? start_index, string sort_by, string commandomode_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all commandomode transitions related to a commandomode</summary>
        /// <param name="count">Number of transitions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="commandomode_token">CommandoMode token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Commando_mode_transition_response>> TransitionsGetAsync(int? count, int? start_index, string sort_by, string commandomode_token, System.Threading.CancellationToken cancellationToken);
    
    }
}