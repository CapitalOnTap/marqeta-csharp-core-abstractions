namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IAuthcontrolsClient
    {
        /// <summary>Lists all auth control exempted MIDs for the program</summary>
        /// <param name="card_product">Card Product Token. Use "null" to get auth controls that are not associated to any card product.</param>
        /// <param name="user">User Token. Use "null" to get auth controls that are not associated to any user.</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Auth_control_exempt_mids_response>> ExemptmidsGetAsync(string card_product, string user, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all auth control exempted MIDs for the program</summary>
        /// <param name="card_product">Card Product Token. Use "null" to get auth controls that are not associated to any card product.</param>
        /// <param name="user">User Token. Use "null" to get auth controls that are not associated to any user.</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Auth_control_exempt_mids_response>> ExemptmidsGetAsync(string card_product, string user, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates an auth control for exempting MIDs</summary>
        /// <param name="body">Auth control exempt MID object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_exempt_mids_response> ExemptmidsPostAsync(Auth_control_exempt_mids_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates an auth control for exempting MIDs</summary>
        /// <param name="body">Auth control exempt MID object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_exempt_mids_response> ExemptmidsPostAsync(Auth_control_exempt_mids_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific auth control exemptmids</summary>
        /// <param name="token">Auth control token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_exempt_mids_response> ExemptmidsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific auth control exemptmids</summary>
        /// <param name="token">Auth control token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_exempt_mids_response> ExemptmidsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates the status an auth control exemptmids</summary>
        /// <param name="token">Auth control token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ExemptmidsPutAsync(string token, Auth_control_exempt_mids_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates the status an auth control exemptmids</summary>
        /// <param name="token">Auth control token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ExemptmidsPutAsync(string token, Auth_control_exempt_mids_update_request body, System.Threading.CancellationToken cancellationToken);
    
    }
}