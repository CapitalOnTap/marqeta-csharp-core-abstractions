namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface ITransactionsClient
    {
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task AdvicesAsync(Advice_request_model body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task AdvicesAsync(Advice_request_model body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns transactions for a specific funding account</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <param name="count">Number of transactions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd)</param>
        /// <param name="type">A comma delimited list of transaction types to include.</param>
        /// <param name="polarity">Type of transactions to retrieve: CREDIT or DEBIT</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> FundingsourceAsync(string funding_source_token, int? count, int? start_index, string fields, Sort_by3? sort_by, string start_date, string end_date, string type, Polarity? polarity, string version, bool? verbose);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns transactions for a specific funding account</summary>
        /// <param name="funding_source_token">Funding Account Token</param>
        /// <param name="count">Number of transactions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd)</param>
        /// <param name="type">A comma delimited list of transaction types to include.</param>
        /// <param name="polarity">Type of transactions to retrieve: CREDIT or DEBIT</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> FundingsourceAsync(string funding_source_token, int? count, int? start_index, string fields, Sort_by3? sort_by, string start_date, string end_date, string type, Polarity? polarity, string version, bool? verbose, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task TokenactivationrequestAsync(Digital_wallet_token_create_request body, string embed);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task TokenactivationrequestAsync(Digital_wallet_token_create_request body, string embed, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Returns related transactions</summary>
        /// <param name="token">Transaction token</param>
        /// <param name="count">Number of transactions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="type">A comma delimited list of transaction types to include</param>
        /// <param name="state">A comma delimited list of transaction states to display e.g. PENDING | CLEARED | COMPLETION | ALL</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> RelatedAsync(string token, int? count, int? start_index, string fields, Sort_by4? sort_by, string start_date, string end_date, string type, string state, string version, bool? verbose);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns related transactions</summary>
        /// <param name="token">Transaction token</param>
        /// <param name="count">Number of transactions to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <param name="start_date">Start Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="end_date">End Date (yyyy-MM-dd | yyyy-MM-ddTHH:mm:ss.SS)</param>
        /// <param name="type">A comma delimited list of transaction types to include</param>
        /// <param name="state">A comma delimited list of transaction states to display e.g. PENDING | CLEARED | COMPLETION | ALL</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Transaction_model> RelatedAsync(string token, int? count, int? start_index, string fields, Sort_by4? sort_by, string start_date, string end_date, string type, string state, string version, bool? verbose, System.Threading.CancellationToken cancellationToken);
    
    }
}