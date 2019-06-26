namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IUserClient
    {
        /// <summary>Get</summary>
        /// <param name="user_or_business_token">User or business token</param>
        /// <param name="count">Number of transfers to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> RecipientAsync(string user_or_business_token, int? count, int? start_index, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get</summary>
        /// <param name="user_or_business_token">User or business token</param>
        /// <param name="count">Number of transfers to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> RecipientAsync(string user_or_business_token, int? count, int? start_index, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Get</summary>
        /// <param name="user_or_business_token">User or business token</param>
        /// <param name="count">Number of transfers to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> SenderAsync(string user_or_business_token, int? count, int? start_index, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get</summary>
        /// <param name="user_or_business_token">User or business token</param>
        /// <param name="count">Number of transfers to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> SenderAsync(string user_or_business_token, int? count, int? start_index, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Query a users velocity control balances</summary>
        /// <param name="user_token">User token</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_balance_response> AvailableAsync(string user_token, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Query a users velocity control balances</summary>
        /// <param name="user_token">User token</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_balance_response> AvailableAsync(string user_token, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
    }
}