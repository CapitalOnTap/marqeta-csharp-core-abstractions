namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.2.0 (NJsonSchema v10.0.20.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class AddressesClient : IAddressesClient
    {
        private string _baseUrl = "/v3";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public AddressesClient(System.Net.Http.HttpClient httpClient)
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
    
        /// <summary>List all addresses for a business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> BusinessAsync(string business_token, string fields)
        {
            return BusinessAsync(business_token, fields, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all addresses for a business</summary>
        /// <param name="business_token">Business Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> BusinessAsync(string business_token, string fields, System.Threading.CancellationToken cancellationToken)
        {
            if (business_token == null)
                throw new System.ArgumentNullException("business_token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/fundingsources/addresses/business/{business_token}?");
            urlBuilder_.Replace("{business_token}", System.Uri.EscapeDataString(ConvertToString(business_token, System.Globalization.CultureInfo.InvariantCulture)));
            if (fields != null) 
            {
                urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(fields, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<CardholderAddressResponse>>(response_, headers_).ConfigureAwait(false);
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
                        if (status_ == "404") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Not Found", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(System.Collections.Generic.ICollection<CardholderAddressResponse>);
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
    
        /// <summary>List all addresses for a user</summary>
        /// <param name="user_token">User Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> UserAsync(string user_token, string fields)
        {
            return UserAsync(user_token, fields, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List all addresses for a user</summary>
        /// <param name="user_token">User Token</param>
        /// <param name="fields">Comma delimited list of fields to return (e.g. field_1,field_2,..)</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CardholderAddressResponse>> UserAsync(string user_token, string fields, System.Threading.CancellationToken cancellationToken)
        {
            if (user_token == null)
                throw new System.ArgumentNullException("user_token");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/fundingsources/addresses/user/{user_token}?");
            urlBuilder_.Replace("{user_token}", System.Uri.EscapeDataString(ConvertToString(user_token, System.Globalization.CultureInfo.InvariantCulture)));
            if (fields != null) 
            {
                urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(fields, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<CardholderAddressResponse>>(response_, headers_).ConfigureAwait(false);
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
                        if (status_ == "404") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Not Found", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(System.Collections.Generic.ICollection<CardholderAddressResponse>);
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