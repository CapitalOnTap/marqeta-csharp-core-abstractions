namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class TransactionsClient : ITransactionsClient
    {
        private string _baseUrl = "/v3";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public TransactionsClient(System.Net.Http.HttpClient httpClient)
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
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task AdvicesAsync(Advice_request_model body)
        {
            return AdvicesAsync(body, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task AdvicesAsync(Advice_request_model body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/advices");
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
    
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
        public System.Threading.Tasks.Task<Transaction_model> FundingsourceAsync(string funding_source_token, int? count, int? start_index, string fields, Sort_by3? sort_by, string start_date, string end_date, string type, Polarity? polarity, string version, bool? verbose)
        {
            return FundingsourceAsync(funding_source_token, count, start_index, fields, sort_by, start_date, end_date, type, polarity, version, verbose, System.Threading.CancellationToken.None);
        }
    
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
        public async System.Threading.Tasks.Task<Transaction_model> FundingsourceAsync(string funding_source_token, int? count, int? start_index, string fields, Sort_by3? sort_by, string start_date, string end_date, string type, Polarity? polarity, string version, bool? verbose, System.Threading.CancellationToken cancellationToken)
        {
            if (funding_source_token == null)
                throw new System.ArgumentNullException("funding_source_token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/fundingsource/{funding_source_token}?");
            urlBuilder_.Replace("{funding_source_token}", System.Uri.EscapeDataString(ConvertToString(funding_source_token, System.Globalization.CultureInfo.InvariantCulture)));
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
            if (start_date != null) 
            {
                urlBuilder_.Append("start_date=").Append(System.Uri.EscapeDataString(ConvertToString(start_date, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (end_date != null) 
            {
                urlBuilder_.Append("end_date=").Append(System.Uri.EscapeDataString(ConvertToString(end_date, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (type != null) 
            {
                urlBuilder_.Append("type=").Append(System.Uri.EscapeDataString(ConvertToString(type, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (polarity != null) 
            {
                urlBuilder_.Append("polarity=").Append(System.Uri.EscapeDataString(ConvertToString(polarity, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (version != null) 
            {
                urlBuilder_.Append("version=").Append(System.Uri.EscapeDataString(ConvertToString(version, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (verbose != null) 
            {
                urlBuilder_.Append("verbose=").Append(System.Uri.EscapeDataString(ConvertToString(verbose, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var objectResponse_ = await ReadObjectResponseAsync<Transaction_model>(response_, headers_).ConfigureAwait(false);
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
            
                        return default(Transaction_model);
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
    
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task TokenactivationrequestAsync(Digital_wallet_token_create_request body, string embed)
        {
            return TokenactivationrequestAsync(body, embed, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task TokenactivationrequestAsync(Digital_wallet_token_create_request body, string embed, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/tokenactivationrequest?");
            if (embed != null) 
            {
                urlBuilder_.Append("embed=").Append(System.Uri.EscapeDataString(ConvertToString(embed, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
        public System.Threading.Tasks.Task<Transaction_model> RelatedAsync(string token, int? count, int? start_index, string fields, Sort_by4? sort_by, string start_date, string end_date, string type, string state, string version, bool? verbose)
        {
            return RelatedAsync(token, count, start_index, fields, sort_by, start_date, end_date, type, state, version, verbose, System.Threading.CancellationToken.None);
        }
    
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
        public async System.Threading.Tasks.Task<Transaction_model> RelatedAsync(string token, int? count, int? start_index, string fields, Sort_by4? sort_by, string start_date, string end_date, string type, string state, string version, bool? verbose, System.Threading.CancellationToken cancellationToken)
        {
            if (token == null)
                throw new System.ArgumentNullException("token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/{token}/related?");
            urlBuilder_.Replace("{token}", System.Uri.EscapeDataString(ConvertToString(token, System.Globalization.CultureInfo.InvariantCulture)));
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
            if (start_date != null) 
            {
                urlBuilder_.Append("start_date=").Append(System.Uri.EscapeDataString(ConvertToString(start_date, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (end_date != null) 
            {
                urlBuilder_.Append("end_date=").Append(System.Uri.EscapeDataString(ConvertToString(end_date, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (type != null) 
            {
                urlBuilder_.Append("type=").Append(System.Uri.EscapeDataString(ConvertToString(type, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (state != null) 
            {
                urlBuilder_.Append("state=").Append(System.Uri.EscapeDataString(ConvertToString(state, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (version != null) 
            {
                urlBuilder_.Append("version=").Append(System.Uri.EscapeDataString(ConvertToString(version, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (verbose != null) 
            {
                urlBuilder_.Append("verbose=").Append(System.Uri.EscapeDataString(ConvertToString(verbose, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var objectResponse_ = await ReadObjectResponseAsync<Transaction_model>(response_, headers_).ConfigureAwait(false);
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
            
                        return default(Transaction_model);
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