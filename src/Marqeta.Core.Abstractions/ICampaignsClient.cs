namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface ICampaignsClient
    {
        /// <summary>Lists all stores associated with a campaign</summary>
        /// <param name="token">Campaign token</param>
        /// <param name="count">Number of items to retrieve. Recommend max 10.</param>
        /// <param name="start_index">Indicates from what row to start returning data. Used in conjunction with count.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field on which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or CreatedTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Store_model>> StoresAsync(string token, int? count, int? start_index, string fields, string sort_by);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Lists all stores associated with a campaign</summary>
        /// <param name="token">Campaign token</param>
        /// <param name="count">Number of items to retrieve. Recommend max 10.</param>
        /// <param name="start_index">Indicates from what row to start returning data. Used in conjunction with count.</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</param>
        /// <param name="sort_by">Field on which to sort the returned items. Use any field in the model, or system fields lastModifiedTime or CreatedTime.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Store_model>> StoresAsync(string token, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken);
    
    }
}