namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IPushtocardsClient
    {
        /// <summary>List all push-to-card disbursements</summary>
        /// <param name="count">Number of Push to card disbursement to retrieve</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Push_to_card_disbursement_response>> DisburseGetAsync(int? count, string fields, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all push-to-card disbursements</summary>
        /// <param name="count">Number of Push to card disbursement to retrieve</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Push_to_card_disbursement_response>> DisburseGetAsync(int? count, string fields, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Initiate a push-to-card money disbursement</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_disbursement_response> DisbursePostAsync(Push_to_card_disburse_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Initiate a push-to-card money disbursement</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_disbursement_response> DisbursePostAsync(Push_to_card_disburse_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific push-to-card disbursement</summary>
        /// <param name="token">Push to Card disbursement token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_disbursement_response> DisburseGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific push-to-card disbursement</summary>
        /// <param name="token">Push to Card disbursement token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_disbursement_response> DisburseGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns all push to card details</summary>
        /// <param name="count">Number of push to card to retrieve</param>
        /// <param name="user_token">user token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Push_to_card_response>> PaymentcardGetAsync(int? count, string user_token, string fields, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns all push to card details</summary>
        /// <param name="count">Number of push to card to retrieve</param>
        /// <param name="user_token">user token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Push_to_card_response>> PaymentcardGetAsync(int? count, string user_token, string fields, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Adds an external card to which funds will be pushed</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_response> PaymentcardPostAsync(Push_to_card_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Adds an external card to which funds will be pushed</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_response> PaymentcardPostAsync(Push_to_card_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific paymentcard object</summary>
        /// <param name="token">Push to Card token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_response> PaymentcardGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific paymentcard object</summary>
        /// <param name="token">Push to Card token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Push_to_card_response> PaymentcardGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
    }
}