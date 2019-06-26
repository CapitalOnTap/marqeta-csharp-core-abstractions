namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IBusinessesClient
    {
        /// <summary>Retrieve a specific business</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessCardHolderModel> LookupAsync(DDARequest body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific business</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessCardHolderModel> LookupAsync(DDARequest body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all children of parent business</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="parent_token">token of parent business</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> ChildrenAsync(int? count, int? start_index, string parent_token, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all children of parent business</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="parent_token">token of parent business</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> ChildrenAsync(int? count, int? start_index, string parent_token, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve Business notes</summary>
        /// <param name="token">Business Token</param>
        /// <param name="start_index">Start index</param>
        /// <param name="count">Number of notes to retrieve</param>
        /// <param name="created_by">Created by</param>
        /// <param name="created_by_user_role">Comma delimited list of created by user roles</param>
        /// <param name="include_private">Include private notes and private field in note response</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task NotesGetAsync(string token, int? start_index, int? count, string created_by, string created_by_user_role, bool? include_private, string search_type, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve Business notes</summary>
        /// <param name="token">Business Token</param>
        /// <param name="start_index">Start index</param>
        /// <param name="count">Number of notes to retrieve</param>
        /// <param name="created_by">Created by</param>
        /// <param name="created_by_user_role">Comma delimited list of created by user roles</param>
        /// <param name="include_private">Include private notes and private field in note response</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task NotesGetAsync(string token, int? start_index, int? count, string created_by, string created_by_user_role, bool? include_private, string search_type, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create a note for Business</summary>
        /// <param name="token">Business Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPostAsync(Cardholder_note_request_model body, string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a note for Business</summary>
        /// <param name="token">Business Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPostAsync(Cardholder_note_request_model body, string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a note for Business</summary>
        /// <param name="token">Business Token</param>
        /// <param name="notes_token">Notes Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPutAsync(Cardholder_note_update_request_model body, string token, string notes_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a note for Business</summary>
        /// <param name="token">Business Token</param>
        /// <param name="notes_token">Notes Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPutAsync(Cardholder_note_update_request_model body, string token, string notes_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific business' proprietor's SSN</summary>
        /// <param name="token">Business token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ssn_response_model> SsnAsync(string token, bool? full_ssn);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific business' proprietor's SSN</summary>
        /// <param name="token">Business token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ssn_response_model> SsnAsync(string token, bool? full_ssn, System.Threading.CancellationToken cancellationToken);
    
    }
}