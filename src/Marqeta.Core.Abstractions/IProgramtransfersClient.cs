namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IProgramtransfersClient
    {
        /// <summary>List all program transfer types</summary>
        /// <param name="count">Number of prog transfer types to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Program_transfer_type_reponse>> TypesGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all program transfer types</summary>
        /// <param name="count">Number of prog transfer types to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Program_transfer_type_reponse>> TypesGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create Program Transfer Type</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_type_reponse> TypesPostAsync(Program_transfer_type_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create Program Transfer Type</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_type_reponse> TypesPostAsync(Program_transfer_type_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific prog transfer type</summary>
        /// <param name="type_token">Type token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_type_reponse> TypesGetAsync(string type_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific prog transfer type</summary>
        /// <param name="type_token">Type token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_type_reponse> TypesGetAsync(string type_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Update a specific prog transfer type</summary>
        /// <param name="type_token">Type token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_type_reponse> TypesPutAsync(string type_token, Program_transfer_type_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a specific prog transfer type</summary>
        /// <param name="type_token">Type token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_type_reponse> TypesPutAsync(string type_token, Program_transfer_type_request body, System.Threading.CancellationToken cancellationToken);
    
    }
}