namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class UsersClient : IUsersClient
    {
        private string _baseUrl = "/v3";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public UsersClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient; 
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() => 
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }
    
        public string BaseUrl 
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
    
        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }
    
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
    
        /// <summary>List all users</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> LookupAsync(User_card_holder_search_model body, int? count, int? start_index, string search_type, string fields, string sort_by)
        {
            return LookupAsync(body, count, start_index, search_type, fields, sort_by, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all users</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="search_type">Search Type</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> LookupAsync(User_card_holder_search_model body, int? count, int? start_index, string search_type, string fields, string sort_by, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/users/lookup?");
            if (count != null) 
            {
                urlBuilder_.Append("count=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (start_index != null) 
            {
                urlBuilder_.Append("start_index=").Append(System.Uri.EscapeDataString(ConvertToString(start_index, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (search_type != null) 
            {
                urlBuilder_.Append("search_type=").Append(System.Uri.EscapeDataString(ConvertToString(search_type, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (fields != null) 
            {
                urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(fields, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (sort_by != null) 
            {
                urlBuilder_.Append("sort_by=").Append(System.Uri.EscapeDataString(ConvertToString(sort_by, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Card_holder_model>>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Bad Request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Server error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(System.Collections.Generic.ICollection<Card_holder_model>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>List all users who match a phone number</summary>
        /// <param name="phone_number">Phone Number</param>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> PhonenumberAsync(string phone_number, int? count, int? start_index, string fields, string sort_by)
        {
            return PhonenumberAsync(phone_number, count, start_index, fields, sort_by, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all users who match a phone number</summary>
        /// <param name="phone_number">Phone Number</param>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> PhonenumberAsync(string phone_number, int? count, int? start_index, string fields, string sort_by, System.Threading.CancellationToken cancellationToken)
        {
            if (phone_number == null)
                throw new System.ArgumentNullException("phone_number");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/users/phonenumber/{phone_number}?");
            urlBuilder_.Replace("{phone_number}", System.Uri.EscapeDataString(ConvertToString(phone_number, System.Globalization.CultureInfo.InvariantCulture)));
            if (count != null) 
            {
                urlBuilder_.Append("count=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (start_index != null) 
            {
                urlBuilder_.Append("start_index=").Append(System.Uri.EscapeDataString(ConvertToString(start_index, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (fields != null) 
            {
                urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(fields, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (sort_by != null) 
            {
                urlBuilder_.Append("sort_by=").Append(System.Uri.EscapeDataString(ConvertToString(sort_by, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Card_holder_model>>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Bad Request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Server error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(System.Collections.Generic.ICollection<Card_holder_model>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>List all children of parent user</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="parent_token">token of parent cardholder</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> ChildrenAsync(int? count, int? start_index, string parent_token, string fields, string sort_by)
        {
            return ChildrenAsync(count, start_index, parent_token, fields, sort_by, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all children of parent user</summary>
        /// <param name="count">Number of users to retrieve</param>
        /// <param name="start_index">Start index</param>
        /// <param name="parent_token">token of parent cardholder</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <param name="sort_by">Sort order</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Card_holder_model>> ChildrenAsync(int? count, int? start_index, string parent_token, string fields, string sort_by, System.Threading.CancellationToken cancellationToken)
        {
            if (parent_token == null)
                throw new System.ArgumentNullException("parent_token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/users/{parent_token}/children?");
            urlBuilder_.Replace("{parent_token}", System.Uri.EscapeDataString(ConvertToString(parent_token, System.Globalization.CultureInfo.InvariantCulture)));
            if (count != null) 
            {
                urlBuilder_.Append("count=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (start_index != null) 
            {
                urlBuilder_.Append("start_index=").Append(System.Uri.EscapeDataString(ConvertToString(start_index, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (fields != null) 
            {
                urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(fields, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (sort_by != null) 
            {
                urlBuilder_.Append("sort_by=").Append(System.Uri.EscapeDataString(ConvertToString(sort_by, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Card_holder_model>>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("User input error/bad request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Server error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(System.Collections.Generic.ICollection<Card_holder_model>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>Retrieve cardholder notes</summary>
        /// <param name="token">User Token</param>
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
        public System.Threading.Tasks.Task NotesGetAsync(string token, int? start_index, int? count, string created_by, string created_by_user_role, bool? include_private, string search_type, string fields, string sort_by)
        {
            return NotesGetAsync(token, start_index, count, created_by, created_by_user_role, include_private, search_type, fields, sort_by, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve cardholder notes</summary>
        /// <param name="token">User Token</param>
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
        public async System.Threading.Tasks.Task NotesGetAsync(string token, int? start_index, int? count, string created_by, string created_by_user_role, bool? include_private, string search_type, string fields, string sort_by, System.Threading.CancellationToken cancellationToken)
        {
            if (token == null)
                throw new System.ArgumentNullException("token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/users/{token}/notes?");
            urlBuilder_.Replace("{token}", System.Uri.EscapeDataString(ConvertToString(token, System.Globalization.CultureInfo.InvariantCulture)));
            if (start_index != null) 
            {
                urlBuilder_.Append("start_index=").Append(System.Uri.EscapeDataString(ConvertToString(start_index, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (count != null) 
            {
                urlBuilder_.Append("count=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (created_by != null) 
            {
                urlBuilder_.Append("created_by=").Append(System.Uri.EscapeDataString(ConvertToString(created_by, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (created_by_user_role != null) 
            {
                urlBuilder_.Append("created_by_user_role=").Append(System.Uri.EscapeDataString(ConvertToString(created_by_user_role, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (include_private != null) 
            {
                urlBuilder_.Append("include_private=").Append(System.Uri.EscapeDataString(ConvertToString(include_private, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (search_type != null) 
            {
                urlBuilder_.Append("search_type=").Append(System.Uri.EscapeDataString(ConvertToString(search_type, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (fields != null) 
            {
                urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(fields, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (sort_by != null) 
            {
                urlBuilder_.Append("sort_by=").Append(System.Uri.EscapeDataString(ConvertToString(sort_by, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            return;
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Bad Request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "401") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Unauthorized", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Server error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "403") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Forbidden", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "404") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Cardholder not found", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>Create a note for cardholder</summary>
        /// <param name="token">User Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPostAsync(Cardholder_note_request_model body, string token)
        {
            return NotesPostAsync(body, token, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a note for cardholder</summary>
        /// <param name="token">User Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPostAsync(Cardholder_note_request_model body, string token, System.Threading.CancellationToken cancellationToken)
        {
            if (token == null)
                throw new System.ArgumentNullException("token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/users/{token}/notes");
            urlBuilder_.Replace("{token}", System.Uri.EscapeDataString(ConvertToString(token, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Cardholder_note_response_model>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "201") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Success", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Bad Request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "401") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Unauthorized", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Server error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "403") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Forbidden", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(Cardholder_note_response_model);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>Updates a note for cardholder</summary>
        /// <param name="token">User Token</param>
        /// <param name="notes_token">Notes Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPutAsync(Cardholder_note_update_request_model body, string token, string notes_token)
        {
            return NotesPutAsync(body, token, notes_token, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates a note for cardholder</summary>
        /// <param name="token">User Token</param>
        /// <param name="notes_token">Notes Token</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Cardholder_note_response_model> NotesPutAsync(Cardholder_note_update_request_model body, string token, string notes_token, System.Threading.CancellationToken cancellationToken)
        {
            if (token == null)
                throw new System.ArgumentNullException("token");
    
            if (notes_token == null)
                throw new System.ArgumentNullException("notes_token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/users/{token}/notes/{notes_token}");
            urlBuilder_.Replace("{token}", System.Uri.EscapeDataString(ConvertToString(token, System.Globalization.CultureInfo.InvariantCulture)));
            urlBuilder_.Replace("{notes_token}", System.Uri.EscapeDataString(ConvertToString(notes_token, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("PUT");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Cardholder_note_response_model>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "201") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Success", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Bad Request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "401") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Unauthorized", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Server error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "403") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Forbidden", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(Cardholder_note_response_model);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>Retrieve a specific user SSN</summary>
        /// <param name="token">User token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Ssn_response_model> SsnAsync(string token, bool? full_ssn)
        {
            return SsnAsync(token, full_ssn, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a specific user SSN</summary>
        /// <param name="token">User token</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Ssn_response_model> SsnAsync(string token, bool? full_ssn, System.Threading.CancellationToken cancellationToken)
        {
            if (token == null)
                throw new System.ArgumentNullException("token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/users/{token}/ssn?");
            urlBuilder_.Replace("{token}", System.Uri.EscapeDataString(ConvertToString(token, System.Globalization.CultureInfo.InvariantCulture)));
            if (full_ssn != null) 
            {
                urlBuilder_.Append("full_ssn=").Append(System.Uri.EscapeDataString(ConvertToString(full_ssn, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Ssn_response_model>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Bad Request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Server error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(Ssn_response_model);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                this.Object = responseObject;
                this.Text = responseText;
            }
    
            public T Object { get; }
    
            public string Text { get; }
        }
    
        public bool ReadResponseAsString { get; set; }
        
        protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers)
        {
            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, null, headers, exception);
                }
            }
        }
    
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) 
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
                }
            }
            else if (value is bool) {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[]) value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array) value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
        
            return System.Convert.ToString(value, cultureInfo);
        }
    }
}