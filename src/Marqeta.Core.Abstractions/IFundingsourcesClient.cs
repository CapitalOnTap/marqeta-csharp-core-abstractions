namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IFundingsourcesClient
    {
        /// <summary>Registers an ACH funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ach_response_model> AchPostAsync(Ach_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Registers an ACH funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ach_response_model> AchPostAsync(Ach_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns an User ACH account</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ach_response_model> AchGetAsync(string funding_source_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns an User ACH account</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ach_response_model> AchGetAsync(string funding_source_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Verifies a bank account as a funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ach_response_model> AchPutAsync(string funding_source_token, Ach_verification_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Verifies a bank account as a funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ach_response_model> AchPutAsync(string funding_source_token, Ach_verification_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create account holder address for a funding source</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CardholderAddressResponse> AddressesPostAsync(Card_holder_address_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create account holder address for a funding source</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CardholderAddressResponse> AddressesPostAsync(Card_holder_address_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Return a user address for a funding source</summary>
        /// <param name="funding_source_address_token">Funding Source Address Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CardholderAddressResponse> AddressesGetAsync(string funding_source_address_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return a user address for a funding source</summary>
        /// <param name="funding_source_address_token">Funding Source Address Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CardholderAddressResponse> AddressesGetAsync(string funding_source_address_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Update account holder address for a funding source</summary>
        /// <param name="funding_source_address_token">Funding Source Address Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CardholderAddressResponse> AddressesPutAsync(string funding_source_address_token, Card_holder_address_update_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update account holder address for a funding source</summary>
        /// <param name="funding_source_address_token">Funding Source Address Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CardholderAddressResponse> AddressesPutAsync(string funding_source_address_token, Card_holder_address_update_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all funding sources for a business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="type">type=paymentcard, ach, etc</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Funding_account_response_model>> BusinessAsync(string business_token, string type, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all funding sources for a business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="type">type=paymentcard, ach, etc</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Funding_account_response_model>> BusinessAsync(string business_token, string type, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Registers a payment card funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> PaymentcardPostAsync(Token_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Registers a payment card funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> PaymentcardPostAsync(Token_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific payment card</summary>
        /// <param name="funding_source_token">Funding Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> PaymentcardGetAsync(string funding_source_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific payment card</summary>
        /// <param name="funding_source_token">Funding Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> PaymentcardGetAsync(string funding_source_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a payment card</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <param name="body">Payment Card</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> PaymentcardPutAsync(string funding_source_token, Token_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a payment card</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <param name="body">Payment Card</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> PaymentcardPutAsync(string funding_source_token, Token_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a program funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_funding_source_response> ProgramPostAsync(Program_funding_source_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a program funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_funding_source_response> ProgramPostAsync(Program_funding_source_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a program funding source</summary>
        /// <param name="token">Program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_funding_source_response> ProgramGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a program funding source</summary>
        /// <param name="token">Program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_funding_source_response> ProgramGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a program funding source</summary>
        /// <param name="token">Program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_funding_source_response> ProgramPutAsync(string token, Program_funding_source_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a program funding source</summary>
        /// <param name="token">Program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_funding_source_response> ProgramPutAsync(string token, Program_funding_source_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a gateway program funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gateway_program_funding_source_response> ProgramgatewayPostAsync(Gateway_program_funding_source_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a gateway program funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gateway_program_funding_source_response> ProgramgatewayPostAsync(Gateway_program_funding_source_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a gateway program funding source</summary>
        /// <param name="token">Gateway program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gateway_program_funding_source_response> ProgramgatewayGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a gateway program funding source</summary>
        /// <param name="token">Gateway program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gateway_program_funding_source_response> ProgramgatewayGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a gateway program funding source</summary>
        /// <param name="token">Gateway program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gateway_program_funding_source_response> ProgramgatewayPutAsync(string token, Gateway_program_funding_source_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a gateway program funding source</summary>
        /// <param name="token">Gateway program funding source token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gateway_program_funding_source_response> ProgramgatewayPutAsync(string token, Gateway_program_funding_source_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all funding sources for a user</summary>
        /// <param name="user_token">User Token</param>
        /// <param name="type">type=paymentcard, ach, etc</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Funding_account_response_model>> UserAsync(string user_token, string type, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all funding sources for a user</summary>
        /// <param name="user_token">User Token</param>
        /// <param name="type">type=paymentcard, ach, etc</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Funding_account_response_model>> UserAsync(string user_token, string type, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Configure a default funding source</summary>
        /// <param name="funding_source_token">Funding Account</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> DefaultAsync(string funding_source_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Configure a default funding source</summary>
        /// <param name="funding_source_token">Funding Account</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Payment_card_response_model> DefaultAsync(string funding_source_token, System.Threading.CancellationToken cancellationToken);
    
    }
}