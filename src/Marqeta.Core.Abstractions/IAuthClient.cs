namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IAuthClient
    {
        /// <summary>Update a user Password</summary>
        /// <param name="body">Password update object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ChangepasswordAsync(Password_update_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a user Password</summary>
        /// <param name="body">Password update object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ChangepasswordAsync(Password_update_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a client access token</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Client_access_token_response> ClientaccesstokenPostAsync(Client_access_token_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a client access token</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Client_access_token_response> ClientaccesstokenPostAsync(Client_access_token_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves a client access token</summary>
        /// <param name="token">client access token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Client_access_token_response> ClientaccesstokenGetAsync(string token, string application_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves a client access token</summary>
        /// <param name="token">client access token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Client_access_token_response> ClientaccesstokenGetAsync(string token, string application_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Logs in a user</summary>
        /// <param name="body">User login object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Login_response_model> LoginAsync(Login_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Logs in a user</summary>
        /// <param name="body">User login object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Login_response_model> LoginAsync(Login_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Logs out a user</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LogoutAsync();
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Logs out a user</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LogoutAsync(System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a one time token</summary>
        /// <param name="body">One time object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Access_token_response> OnetimeAsync(One_time_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a one time token</summary>
        /// <param name="body">One time object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Access_token_response> OnetimeAsync(One_time_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Generates a reset password email</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ResetpasswordPostAsync(Reset_user_password_email_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Generates a reset password email</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ResetpasswordPostAsync(Reset_user_password_email_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Reset user password</summary>
        /// <param name="token">Reset password verification token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ResetpasswordPostAsync(Reset_user_password_model body, string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Reset user password</summary>
        /// <param name="token">Reset password verification token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ResetpasswordPostAsync(Reset_user_password_model body, string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Generates an email verification request</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task VerifyemailPostAsync();
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Generates an email verification request</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task VerifyemailPostAsync(System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Verify the email token</summary>
        /// <param name="token">Email verification token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task VerifyemailPostAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Verify the email token</summary>
        /// <param name="token">Email verification token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task VerifyemailPostAsync(string token, System.Threading.CancellationToken cancellationToken);
    
    }
}