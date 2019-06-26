namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IProgramClient
    {
        /// <summary>Returns a list of Program ACH funding sources</summary>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Base_ach_response_model> AchGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a list of Program ACH funding sources</summary>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Base_ach_response_model> AchGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Registers an ACH funding source for a program</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Base_ach_response_model> AchPostAsync(Base_ach_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Registers an ACH funding source for a program</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Base_ach_response_model> AchPostAsync(Base_ach_request_model body, System.Threading.CancellationToken cancellationToken);
    
    }
}