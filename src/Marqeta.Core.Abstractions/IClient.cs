namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IClient
    {
        /// <summary>List all the accepted countries</summary>
        /// <param name="count">Number of accepted countries to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="name">Name</param>
        /// <param name="whitelist">Whitelist</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Accepted_countries_model>> AcceptedcountriesGetAsync(int? count, int? start_index, string name, bool? whitelist, string search_type, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all the accepted countries</summary>
        /// <param name="count">Number of accepted countries to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="name">Name</param>
        /// <param name="whitelist">Whitelist</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Accepted_countries_model>> AcceptedcountriesGetAsync(int? count, int? start_index, string name, bool? whitelist, string search_type, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create an accepted country</summary>
        /// <param name="body">Accepted Country object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Accepted_countries_model> AcceptedcountriesPostAsync(Accepted_countries_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create an accepted country</summary>
        /// <param name="body">Accepted Country object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Accepted_countries_model> AcceptedcountriesPostAsync(Accepted_countries_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific accepted country by token</summary>
        /// <param name="token">Accepted Country token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Accepted_countries_model> AcceptedcountriesGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific accepted country by token</summary>
        /// <param name="token">Accepted Country token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Accepted_countries_model> AcceptedcountriesGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Update an accepted country</summary>
        /// <param name="body">Accepted Country</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Accepted_countries_model> AcceptedcountriesPutAsync(Accepted_countries_update_model body, string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update an accepted country</summary>
        /// <param name="body">Accepted Country</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Accepted_countries_model> AcceptedcountriesPutAsync(Accepted_countries_update_model body, string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all account holder groups</summary>
        /// <param name="count">Number of items to retrieve. Count is allow from 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Account_holder_group_response>> AccountholdergroupsGetAsync(int? count, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all account holder groups</summary>
        /// <param name="count">Number of items to retrieve. Count is allow from 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Account_holder_group_response>> AccountholdergroupsGetAsync(int? count, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates an account holder group object</summary>
        /// <param name="body">Account holder group object</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Account_holder_group_response> AccountholdergroupsPostAsync(Account_holder_group_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates an account holder group object</summary>
        /// <param name="body">Account holder group object</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Account_holder_group_response> AccountholdergroupsPostAsync(Account_holder_group_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific account holder group object</summary>
        /// <param name="token">Account holder group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Account_holder_group_response> AccountholdergroupsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific account holder group object</summary>
        /// <param name="token">Account holder group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Account_holder_group_response> AccountholdergroupsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates an account holder group object</summary>
        /// <param name="body">Account holder group update object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task AccountholdergroupsPutAsync(Account_holder_group_update_request body, string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates an account holder group object</summary>
        /// <param name="body">Account holder group update object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task AccountholdergroupsPutAsync(Account_holder_group_update_request body, string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all global auth control exceptions for the program</summary>
        /// <param name="card_product">Card Product Token. Use "null" to get auth controls that are not associated to any card product.</param>
        /// <param name="user">User Token. Use "null" to get auth controls that are not associated to any user.</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Auth_control_response>> AuthcontrolsGetAsync(string card_product, string user, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all global auth control exceptions for the program</summary>
        /// <param name="card_product">Card Product Token. Use "null" to get auth controls that are not associated to any card product.</param>
        /// <param name="user">User Token. Use "null" to get auth controls that are not associated to any user.</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Auth_control_response>> AuthcontrolsGetAsync(string card_product, string user, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates an auth control exception</summary>
        /// <param name="body">Auth control object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_response> AuthcontrolsPostAsync(Auth_control_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates an auth control exception</summary>
        /// <param name="body">Auth control object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_response> AuthcontrolsPostAsync(Auth_control_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific auth control exception</summary>
        /// <param name="token">Auth control token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_response> AuthcontrolsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific auth control exception</summary>
        /// <param name="token">Auth control token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_response> AuthcontrolsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates an auth control exception</summary>
        /// <param name="token">Auth control token</param>
        /// <param name="body">Auth control object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_response> AuthcontrolsPutAsync(string token, Auth_control_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates an auth control exception</summary>
        /// <param name="token">Auth control token</param>
        /// <param name="body">Auth control object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auth_control_response> AuthcontrolsPutAsync(string token, Auth_control_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all auto reload for the program</summary>
        /// <param name="card_product">Card Product Token</param>
        /// <param name="user_token">User Token</param>
        /// <param name="business_token">Business Token</param>
        /// <param name="count">Number of items to retrieve. Count is allow from 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Auto_reload_response_model>> AutoreloadsGetAsync(string card_product, string user_token, string business_token, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all auto reload for the program</summary>
        /// <param name="card_product">Card Product Token</param>
        /// <param name="user_token">User Token</param>
        /// <param name="business_token">Business Token</param>
        /// <param name="count">Number of items to retrieve. Count is allow from 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Auto_reload_response_model>> AutoreloadsGetAsync(string card_product, string user_token, string business_token, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates an auto reload object</summary>
        /// <param name="body">Auto reload object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auto_reload_response_model> AutoreloadsPostAsync(Auto_reload_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates an auto reload object</summary>
        /// <param name="body">Auto reload object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auto_reload_response_model> AutoreloadsPostAsync(Auto_reload_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific auto reload object</summary>
        /// <param name="token">Auto reload token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auto_reload_response_model> AutoreloadsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific auto reload object</summary>
        /// <param name="token">Auto reload token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auto_reload_response_model> AutoreloadsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates an auto reload object</summary>
        /// <param name="body">Auto reload object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auto_reload_response_model> AutoreloadsPutAsync(Auto_reload_update_model body, string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates an auto reload object</summary>
        /// <param name="body">Auto reload object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Auto_reload_response_model> AutoreloadsPutAsync(Auto_reload_update_model body, string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve account balances for a Cardholder</summary>
        /// <param name="token">User or Business token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_balances> BalancesAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve account balances for a Cardholder</summary>
        /// <param name="token">User or Business token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Cardholder_balances> BalancesAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all bulk issuance requests</summary>
        /// <param name="count">Number of requests to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Bulk_issuance_response>> BulkissuancesGetAsync(int? count, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all bulk issuance requests</summary>
        /// <param name="count">Number of requests to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Bulk_issuance_response>> BulkissuancesGetAsync(int? count, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a bulk issuance request for cards</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Bulk_issuance_response> BulkissuancesPostAsync(Bulk_issuance_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a bulk issuance request for cards</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Bulk_issuance_response> BulkissuancesPostAsync(Bulk_issuance_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns bulk issuance request</summary>
        /// <param name="token">Bulk Issuance Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Bulk_issuance_response> BulkissuancesGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns bulk issuance request</summary>
        /// <param name="token">Bulk Issuance Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Bulk_issuance_response> BulkissuancesGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all businesses</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="business_name_dba">Business Name DBA</param>
        /// <param name="business_name_legal">Business Name Legal</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BusinessCardHolderModel>> BusinessesGetAsync(int? count, int? start_index, string business_name_dba, string business_name_legal, string search_type, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all businesses</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="business_name_dba">Business Name DBA</param>
        /// <param name="business_name_legal">Business Name Legal</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BusinessCardHolderModel>> BusinessesGetAsync(int? count, int? start_index, string business_name_dba, string business_name_legal, string search_type, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create a Business</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Business_card_holder_response> BusinessesPostAsync(BusinessCardHolderModel body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a Business</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Business_card_holder_response> BusinessesPostAsync(BusinessCardHolderModel body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific business</summary>
        /// <param name="token">Business token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Business_card_holder_response> BusinessesGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific business</summary>
        /// <param name="token">Business token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Business_card_holder_response> BusinessesGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Update a business</summary>
        /// <param name="token">Business token</param>
        /// <param name="body">Business object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessCardHolderModel> BusinessesPutAsync(string token, BusinessCardHolderUpdateModel body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a business</summary>
        /// <param name="token">Business token</param>
        /// <param name="body">Business object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessCardHolderModel> BusinessesPutAsync(string token, BusinessCardHolderUpdateModel body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create a business transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessTransitionResponse> BusinesstransitionsPostAsync(BusinessTransitionRequest body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a business transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessTransitionResponse> BusinesstransitionsPostAsync(BusinessTransitionRequest body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a business transition</summary>
        /// <param name="token">Transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessTransitionResponse> BusinesstransitionsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a business transition</summary>
        /// <param name="token">Transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BusinessTransitionResponse> BusinesstransitionsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all campaigns</summary>
        /// <param name="count">Number of items to retrieve. Recommend max 10.</param>
        /// <param name="start_index">Indicates from what row to start returning data. Used in conjunction with count.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field on which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or CreatedTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Campaign_response_model>> CampaignsGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all campaigns</summary>
        /// <param name="count">Number of items to retrieve. Recommend max 10.</param>
        /// <param name="start_index">Indicates from what row to start returning data. Used in conjunction with count.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field on which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or CreatedTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Campaign_response_model>> CampaignsGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a campaign</summary>
        /// <returns>Campaign created successfully</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Campaign_response_model> CampaignsPostAsync(Campaign_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a campaign</summary>
        /// <returns>Campaign created successfully</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Campaign_response_model> CampaignsPostAsync(Campaign_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific campaign</summary>
        /// <param name="token">Campaign token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Campaign_response_model> CampaignsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific campaign</summary>
        /// <param name="token">Campaign token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Campaign_response_model> CampaignsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a campaign</summary>
        /// <param name="token">Campaign token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Campaign_response_model> CampaignsPutAsync(string token, Campaign_update_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a campaign</summary>
        /// <param name="token">Campaign token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Campaign_response_model> CampaignsPutAsync(string token, Campaign_update_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all card products</summary>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsGetAsync(int? count, int? start_index);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all card products</summary>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsGetAsync(int? count, int? start_index, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a card product</summary>
        /// <param name="body">Card product object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsPostAsync(Card_product_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a card product</summary>
        /// <param name="body">Card product object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsPostAsync(Card_product_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific card product</summary>
        /// <param name="token">Card product token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific card product</summary>
        /// <param name="token">Card product token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a card product</summary>
        /// <param name="token">Card product token</param>
        /// <param name="body">Card product object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsPutAsync(string token, Card_product_update_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a card product</summary>
        /// <param name="token">Card product token</param>
        /// <param name="body">Card product object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_product_response> CardproductsPutAsync(string token, Card_product_update_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List cards by last 4</summary>
        /// <param name="count">Number of cards to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="last_four">Last Four</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_response>> CardsGetAsync(int? count, int? start_index, string last_four, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List cards by last 4</summary>
        /// <param name="count">Number of cards to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="last_four">Last Four</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_response>> CardsGetAsync(int? count, int? start_index, string last_four, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a card</summary>
        /// <param name="show_cvv_number">Show cvv</param>
        /// <param name="show_pan">Show pan</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> CardsPostAsync(Card_request body, bool? show_cvv_number, bool? show_pan);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a card</summary>
        /// <param name="show_cvv_number">Show cvv</param>
        /// <param name="show_pan">Show pan</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> CardsPostAsync(Card_request body, bool? show_cvv_number, bool? show_pan, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific card</summary>
        /// <param name="token">Card token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="expand">Object to expand</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> CardsGetAsync(string token, string fields, string expand);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific card</summary>
        /// <param name="token">Card token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="expand">Object to expand</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> CardsGetAsync(string token, string fields, string expand, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a card</summary>
        /// <param name="token">Card token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> CardsPutAsync(string token, Card_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a card</summary>
        /// <param name="token">Card token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_response> CardsPutAsync(string token, Card_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a card transition object</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_transition_response> CardtransitionsPostAsync(Card_transition_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a card transition object</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_transition_response> CardtransitionsPostAsync(Card_transition_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a card transition object</summary>
        /// <param name="token">Card transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_transition_response> CardtransitionsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a card transition object</summary>
        /// <param name="token">Card transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_transition_response> CardtransitionsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all chargebacks</summary>
        /// <param name="count">Number of chargebacks to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="network_reference_id">Network reference Id</param>
        /// <param name="transaction_token">Transaction token</param>
        /// <param name="amount">Amount</param>
        /// <param name="states">A comma delimited list of chargeback state(s) to display e.g. INITIATED | REPRESENTMENT | PREARBITRATION | ARBITRATION | CASE_WON | CASE_LOST | NETWORK_REJECTED | WRITTEN_OFF_ISSUER | WRITTEN_OFF_PROGRAM</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Chargeback_response>> ChargebacksGetAsync(int? count, int? start_index, string network_reference_id, string transaction_token, string amount, string states, string sort_by, string network_case_id);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all chargebacks</summary>
        /// <param name="count">Number of chargebacks to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="network_reference_id">Network reference Id</param>
        /// <param name="transaction_token">Transaction token</param>
        /// <param name="amount">Amount</param>
        /// <param name="states">A comma delimited list of chargeback state(s) to display e.g. INITIATED | REPRESENTMENT | PREARBITRATION | ARBITRATION | CASE_WON | CASE_LOST | NETWORK_REJECTED | WRITTEN_OFF_ISSUER | WRITTEN_OFF_PROGRAM</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Chargeback_response>> ChargebacksGetAsync(int? count, int? start_index, string network_reference_id, string transaction_token, string amount, string states, string sort_by, string network_case_id, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a chargeback</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_response> ChargebacksPostAsync(Chargeback_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a chargeback</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_response> ChargebacksPostAsync(Chargeback_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a chargeback</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_response> ChargebacksGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a chargeback</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Chargeback_response> ChargebacksGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates chargeback data</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ChargebacksPutAsync(string token, ChargebackUpdateRequest body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates chargeback data</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ChargebacksPutAsync(string token, ChargebackUpdateRequest body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all commandomodes</summary>
        /// <param name="count">Number of commando modes to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Commando_mode_response>> CommandomodesGetAsync(int? count, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all commandomodes</summary>
        /// <param name="count">Number of commando modes to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Commando_mode_response>> CommandomodesGetAsync(int? count, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a commandomode</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Commando_mode_response> CommandomodesGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a commandomode</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Commando_mode_response> CommandomodesGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns Digital Wallet Tokens</summary>
        /// <param name="count">Number of digital wallet tokens to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd)</param>
        /// <param name="pan_reference_id">Pan Reference Id</param>
        /// <param name="token_reference_id">Token Reference Id</param>
        /// <param name="correlation_id">Correlation Id</param>
        /// <param name="token_type">A comma delimited list of digital wallet tokens types to display e.g. DEVICE_SECURE_ELEMENT | MERCHANT_CARD_ON_FILE | DEVICE_CLOUD_BASED | ECOMMERCE_DIGITAL_WALLET | PSEUDO_ACCOUNT</param>
        /// <param name="token_requestor_name">A comma delimited list of digital wallet token wallet providers to display e.g. APPLE_PAY | ANDROID_PAY| SAMSUNG_PAY | MICROSOFT_PAY | VISA_CHECKOUT | FACEBOOK | NETFLIX | UNKNOWN</param>
        /// <param name="state">A comma delimited list of digital wallet tokens states to display e.g. REQUESTED | REQUEST_DECLINED | TERMINATED | SUSPENDED | ACTIVE</param>
        /// <param name="embed">embed</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> DigitalwallettokensGetAsync(int? count, int? start_index, string fields, Sort_by? sort_by, string start_date, string end_date, string pan_reference_id, string token_reference_id, string correlation_id, string token_type, string token_requestor_name, string state, string embed);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns Digital Wallet Tokens</summary>
        /// <param name="count">Number of digital wallet tokens to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd)</param>
        /// <param name="pan_reference_id">Pan Reference Id</param>
        /// <param name="token_reference_id">Token Reference Id</param>
        /// <param name="correlation_id">Correlation Id</param>
        /// <param name="token_type">A comma delimited list of digital wallet tokens types to display e.g. DEVICE_SECURE_ELEMENT | MERCHANT_CARD_ON_FILE | DEVICE_CLOUD_BASED | ECOMMERCE_DIGITAL_WALLET | PSEUDO_ACCOUNT</param>
        /// <param name="token_requestor_name">A comma delimited list of digital wallet token wallet providers to display e.g. APPLE_PAY | ANDROID_PAY| SAMSUNG_PAY | MICROSOFT_PAY | VISA_CHECKOUT | FACEBOOK | NETFLIX | UNKNOWN</param>
        /// <param name="state">A comma delimited list of digital wallet tokens states to display e.g. REQUESTED | REQUEST_DECLINED | TERMINATED | SUSPENDED | ACTIVE</param>
        /// <param name="embed">embed</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> DigitalwallettokensGetAsync(int? count, int? start_index, string fields, Sort_by? sort_by, string start_date, string end_date, string pan_reference_id, string token_reference_id, string correlation_id, string token_type, string token_requestor_name, string state, string embed, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific digital wallet token</summary>
        /// <param name="token">Digital Wallet token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> DigitalwallettokensGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific digital wallet token</summary>
        /// <param name="token">Digital Wallet token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token> DigitalwallettokensGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a digital wallet token transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token_transition_response> DigitalwallettokentransitionsPostAsync(Digital_wallet_token_transition_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a digital wallet token transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token_transition_response> DigitalwallettokentransitionsPostAsync(Digital_wallet_token_transition_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a digital wallet transition object</summary>
        /// <param name="token">Digital wallet transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token_transition_response> DigitalwallettokentransitionsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a digital wallet transition object</summary>
        /// <param name="token">Digital wallet transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Digital_wallet_token_transition_response> DigitalwallettokentransitionsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all direct deposits</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="reversed_after_grace_period">Reversed after grace period</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="direct_deposit_state">Direct Deposit State</param>
        /// <param name="start_settlement_date">Start settlement Date</param>
        /// <param name="end_settlement_date">End settlement Date</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<DepositDepositResponse>> DirectdepositsGetAsync(int? count, int? start_index, bool? reversed_after_grace_period, string user_token, string business_token, Direct_deposit_state? direct_deposit_state, string start_settlement_date, string end_settlement_date, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all direct deposits</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="reversed_after_grace_period">Reversed after grace period</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="direct_deposit_state">Direct Deposit State</param>
        /// <param name="start_settlement_date">Start settlement Date</param>
        /// <param name="end_settlement_date">End settlement Date</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<DepositDepositResponse>> DirectdepositsGetAsync(int? count, int? start_index, bool? reversed_after_grace_period, string user_token, string business_token, Direct_deposit_state? direct_deposit_state, string start_settlement_date, string end_settlement_date, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a direct deposit entry</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DepositDepositResponse> DirectdepositsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a direct deposit entry</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DepositDepositResponse> DirectdepositsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all fees</summary>
        /// <param name="count">Number of fees to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all fees</summary>
        /// <param name="count">Number of fees to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a fee</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesPostAsync(Fee_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a fee</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesPostAsync(Fee_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific fee</summary>
        /// <param name="token">Fee token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific fee</summary>
        /// <param name="token">Fee token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a fee</summary>
        /// <param name="token">Fee token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesPutAsync(string token, Fee_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a fee</summary>
        /// <param name="token">Fee token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee> FeesPutAsync(string token, Fee_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a fee transfer</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee_transfer_response> FeetransfersPostAsync(Fee_transfer_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a fee transfer</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee_transfer_response> FeetransfersPostAsync(Fee_transfer_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a fee transfer</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee_transfer_response> FeetransfersGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a fee transfer</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Fee_transfer_response> FeetransfersGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Fund a user's GPA account</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_response> GpaordersPostAsync(Gpa_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fund a user's GPA account</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_response> GpaordersPostAsync(Gpa_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a GPA order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_response> GpaordersGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a GPA order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Gpa_response> GpaordersGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Performs a KYC</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Kyc_response> KycPostAsync(Kyc_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Performs a KYC</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Kyc_response> KycPostAsync(Kyc_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific KYC result</summary>
        /// <param name="token">KYC Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Kyc_response> KycGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific KYC result</summary>
        /// <param name="token">KYC Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Kyc_response> KycGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Accepts KYC Answers for questions from initial request</summary>
        /// <param name="token">KYC Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Kyc_response> KycPutAsync(string token, KYCSubmitAnswersRequestModel body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Accepts KYC Answers for questions from initial request</summary>
        /// <param name="token">KYC Token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Kyc_response> KycPutAsync(string token, KYCSubmitAnswersRequestModel body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all MCC Groups</summary>
        /// <param name="mcc">MCC</param>
        /// <param name="count">Number of items to retrieve. Count is allow from 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Mcc_group_model>> MccgroupsGetAsync(string mcc, int? count, int? start_index, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all MCC Groups</summary>
        /// <param name="mcc">MCC</param>
        /// <param name="count">Number of items to retrieve. Count is allow from 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Mcc_group_model>> MccgroupsGetAsync(string mcc, int? count, int? start_index, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates an MCC Group</summary>
        /// <param name="body">MCC Group</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Mcc_group_model> MccgroupsPostAsync(Mcc_group_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates an MCC Group</summary>
        /// <param name="body">MCC Group</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Mcc_group_model> MccgroupsPostAsync(Mcc_group_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific MCC group</summary>
        /// <param name="token">MCC Group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Mcc_group_model> MccgroupsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific MCC group</summary>
        /// <param name="token">MCC Group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Mcc_group_model> MccgroupsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates an MCC Group</summary>
        /// <param name="body">MCCGroup</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Mcc_group_update_model> MccgroupsPutAsync(Mcc_group_update_model body, string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates an MCC Group</summary>
        /// <param name="body">MCCGroup</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Mcc_group_update_model> MccgroupsPutAsync(Mcc_group_update_model body, string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all merchants</summary>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Merchant_response_model>> MerchantsGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all merchants</summary>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Merchant_response_model>> MerchantsGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a merchant</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Merchant_response_model> MerchantsPostAsync(Merchant_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a merchant</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Merchant_response_model> MerchantsPostAsync(Merchant_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific merchant</summary>
        /// <param name="token">Merchant token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Merchant_response_model> MerchantsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific merchant</summary>
        /// <param name="token">Merchant token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Merchant_response_model> MerchantsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a merchant</summary>
        /// <param name="token">Merchant token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Merchant_response_model> MerchantsPutAsync(string token, Merchant_update_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a merchant</summary>
        /// <param name="token">Merchant token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Merchant_response_model> MerchantsPutAsync(string token, Merchant_update_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a merchant-specific account order</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_order_response> MsaordersPostAsync(Msa_order_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a merchant-specific account order</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_order_response> MsaordersPostAsync(Msa_order_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns an MSA order</summary>
        /// <param name="token">Order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_order_response> MsaordersGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns an MSA order</summary>
        /// <param name="token">Order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_order_response> MsaordersGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a merchant-specific account order</summary>
        /// <param name="token">Order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_order_response> MsaordersPutAsync(string token, Msa_order_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a merchant-specific account order</summary>
        /// <param name="token">Order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Msa_order_response> MsaordersPutAsync(string token, Msa_order_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates an offer order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_order_response> OfferordersPostAsync(Offer_order_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates an offer order</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_order_response> OfferordersPostAsync(Offer_order_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a purchase order for a specific offer</summary>
        /// <param name="token">Order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_order_response> OfferordersGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a purchase order for a specific offer</summary>
        /// <param name="token">Order token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_order_response> OfferordersGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all offers</summary>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Offer_response_model>> OffersGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all offers</summary>
        /// <param name="count">Number of items to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Offer_response_model>> OffersGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates an offer</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_response_model> OffersPostAsync(Offer_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates an offer</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_response_model> OffersPostAsync(Offer_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific offer</summary>
        /// <param name="token">Offer token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_response_model> OffersGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific offer</summary>
        /// <param name="token">Offer token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_response_model> OffersGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates an offer</summary>
        /// <param name="token">Offer token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_response_model> OffersPutAsync(string token, Offer_update_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates an offer</summary>
        /// <param name="token">Offer token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Offer_response_model> OffersPutAsync(string token, Offer_update_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Post</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> PeertransfersPostAsync(Peer_transfer_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Post</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> PeertransfersPostAsync(Peer_transfer_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Get</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> PeertransfersGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Peer_transfer_response> PeertransfersGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a heartbeat to the consumer</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ping_response> PingGetAsync();
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a heartbeat to the consumer</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Ping_response> PingGetAsync(System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Echo test for sending payload to server</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Echo_ping_response> PingPostAsync(Echo_ping_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Echo test for sending payload to server</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Echo_ping_response> PingPostAsync(Echo_ping_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates the PIN control token</summary>
        /// <returns>PIN was successfully set</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task PinsAsync(Pin_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates the PIN control token</summary>
        /// <returns>PIN was successfully set</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task PinsAsync(Pin_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all program transfers</summary>
        /// <param name="count">Number of program transfers to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="type_token">Program Type token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Program_transfer_response>> ProgramtransfersGetAsync(int? count, int? start_index, string fields, string sort_by, string user_token, string business_token, string type_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all program transfers</summary>
        /// <param name="count">Number of program transfers to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="type_token">Program Type token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Program_transfer_response>> ProgramtransfersGetAsync(int? count, int? start_index, string fields, string sort_by, string user_token, string business_token, string type_token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Transfer to program funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_response> ProgramtransfersPostAsync(Program_transfer body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transfer to program funding source</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_response> ProgramtransfersPostAsync(Program_transfer body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific program transfer</summary>
        /// <param name="token">Program transfer token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_response> ProgramtransfersGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific program transfer</summary>
        /// <param name="token">Program transfer token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Program_transfer_response> ProgramtransfersGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all real time fee groups</summary>
        /// <param name="count">Number of real time fee groups to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all real time fee groups</summary>
        /// <param name="count">Number of real time fee groups to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a real time fee group</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsPostAsync(Real_time_fee_group_create_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a real time fee group</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsPostAsync(Real_time_fee_group_create_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific real time fee group</summary>
        /// <param name="token">Real Time Fee Group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific real time fee group</summary>
        /// <param name="token">Real Time Fee Group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a real time fee group</summary>
        /// <param name="token">Real Time Fee Group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsPutAsync(string token, Real_time_fee_group_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a real time fee group</summary>
        /// <param name="token">Real Time Fee Group token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Real_time_fee_group> RealtimefeegroupsPutAsync(string token, Real_time_fee_group_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Lists all stores</summary>
        /// <param name="count">Number of stores to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Store_response_model>> StoresGetAsync(int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all stores</summary>
        /// <param name="count">Number of stores to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Store_response_model>> StoresGetAsync(int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a store</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Store_response_model> StoresPostAsync(Store_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a store</summary>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Store_response_model> StoresPostAsync(Store_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves a specific store</summary>
        /// <param name="token">Store token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leaveblank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Store_response_model> StoresGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves a specific store</summary>
        /// <param name="token">Store token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leaveblank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Store_response_model> StoresGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a store</summary>
        /// <param name="token">Store token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Store_response_model> StoresPutAsync(string token, Store_update_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a store</summary>
        /// <param name="token">Store token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Store_response_model> StoresPutAsync(string token, Store_update_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns transactions</summary>
        /// <param name="count">Number of transactions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="type">A comma delimited list of transaction types to include.</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="acting_user_token">Acting user token</param>
        /// <param name="card_token">Card token</param>
        /// <param name="merchant_token">Merchant token</param>
        /// <param name="campaign_token">Campaign token</param>
        /// <param name="state">A comma delimited list of transaction states to display e.g. PENDING | CLEARED | COMPLETION | DECLINED | ERROR | ALL</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> TransactionsGetAsync(int? count, int? start_index, string fields, Sort_by2? sort_by, string start_date, string end_date, string type, string user_token, string business_token, string acting_user_token, string card_token, string merchant_token, string campaign_token, string state, string version, bool? verbose);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns transactions</summary>
        /// <param name="count">Number of transactions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="type">A comma delimited list of transaction types to include.</param>
        /// <param name="user_token">User token</param>
        /// <param name="business_token">Business token</param>
        /// <param name="acting_user_token">Acting user token</param>
        /// <param name="card_token">Card token</param>
        /// <param name="merchant_token">Merchant token</param>
        /// <param name="campaign_token">Campaign token</param>
        /// <param name="state">A comma delimited list of transaction states to display e.g. PENDING | CLEARED | COMPLETION | DECLINED | ERROR | ALL</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> TransactionsGetAsync(int? count, int? start_index, string fields, Sort_by2? sort_by, string start_date, string end_date, string type, string user_token, string business_token, string acting_user_token, string card_token, string merchant_token, string campaign_token, string state, string version, bool? verbose, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a transaction</summary>
        /// <param name="token">Transaction token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> TransactionsGetAsync(string token, string fields, string version, bool? verbose);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a transaction</summary>
        /// <param name="token">Transaction token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> TransactionsGetAsync(string token, string fields, string version, bool? verbose, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>List all users</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> UsersGetAsync(int? count, int? start_index, string search_type, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all users</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> UsersGetAsync(int? count, int? start_index, string search_type, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create a user</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<User_card_holder_response> UsersPostAsync(Card_holder_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a user</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<User_card_holder_response> UsersPostAsync(Card_holder_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a specific user</summary>
        /// <param name="token">User token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<User_card_holder_response> UsersGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific user</summary>
        /// <param name="token">User token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<User_card_holder_response> UsersGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Update a user</summary>
        /// <param name="token">User token</param>
        /// <param name="body">User object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_holder_model> UsersPutAsync(string token, UserCardHolderUpdateModel body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a user</summary>
        /// <param name="token">User token</param>
        /// <param name="body">User object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Card_holder_model> UsersPutAsync(string token, UserCardHolderUpdateModel body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create a user transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<UserTransitionResponse> UsertransitionsPostAsync(UserTransitionRequest body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a user transition</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<UserTransitionResponse> UsertransitionsPostAsync(UserTransitionRequest body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieve a user transition</summary>
        /// <param name="token">Transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<UserTransitionResponse> UsertransitionsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a user transition</summary>
        /// <param name="token">Transition token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<UserTransitionResponse> UsertransitionsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Query velocity controls</summary>
        /// <param name="card_product">Card Product Token. Use "null" to get velocity controls that are not associated to any card product.</param>
        /// <param name="user">User Token. Use "null" to get velocity controls that are not associated to any user.</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Velocity_control_response>> VelocitycontrolsGetAsync(string card_product, string user, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Query velocity controls</summary>
        /// <param name="card_product">Card Product Token. Use "null" to get velocity controls that are not associated to any card product.</param>
        /// <param name="user">User Token. Use "null" to get velocity controls that are not associated to any user.</param>
        /// <param name="count">Number of items to retrieve. Count can be between 1 - 10 items.</param>
        /// <param name="start_index">Indicates from what row to start returning data.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field by which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or createdTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Velocity_control_response>> VelocitycontrolsGetAsync(string card_product, string user, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a velocity control</summary>
        /// <param name="body">Velocity control object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_response> VelocitycontrolsPostAsync(Velocity_control_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a velocity control</summary>
        /// <param name="body">Velocity control object</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_response> VelocitycontrolsPostAsync(Velocity_control_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a specific velocity control</summary>
        /// <param name="token">Velocity control token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_response> VelocitycontrolsGetAsync(string token, string fields);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a specific velocity control</summary>
        /// <param name="token">Velocity control token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_response> VelocitycontrolsGetAsync(string token, string fields, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates a velocity control</summary>
        /// <param name="token">Velocity control token</param>
        /// <param name="body">Velocity control object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_response> VelocitycontrolsPutAsync(string token, Velocity_control_update_request body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a velocity control</summary>
        /// <param name="token">Velocity control token</param>
        /// <param name="body">Velocity control object</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Velocity_control_response> VelocitycontrolsPutAsync(string token, Velocity_control_update_request body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a list of webhook configurations</summary>
        /// <param name="active">Return only active webhook configurations</param>
        /// <param name="count">Number of reward programs to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksGetAsync(bool? active, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a list of webhook configurations</summary>
        /// <param name="active">Return only active webhook configurations</param>
        /// <param name="count">Number of reward programs to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksGetAsync(bool? active, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Create a webhook configuration</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksPostAsync(Webhook_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a webhook configuration</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksPostAsync(Webhook_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns a webhook configuration</summary>
        /// <param name="token">Webhook token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksGetAsync(string token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a webhook configuration</summary>
        /// <param name="token">Webhook token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksGetAsync(string token, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Update a webhook configuration</summary>
        /// <param name="token">Webhook token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksPutAsync(string token, Webhook_base_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a webhook configuration</summary>
        /// <param name="token">Webhook token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Webhook_response_model> WebhooksPutAsync(string token, Webhook_base_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Replay an event to a webhook</summary>
        /// <param name="token">Webhook token</param>
        /// <param name="event_type">Event type</param>
        /// <param name="event_token">Event token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task WebhooksPostAsync(string token, Event_type event_type, string event_token);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Replay an event to a webhook</summary>
        /// <param name="token">Webhook token</param>
        /// <param name="event_type">Event type</param>
        /// <param name="event_token">Event token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task WebhooksPostAsync(string token, Event_type event_type, string event_token, System.Threading.CancellationToken cancellationToken);
    
    }
}