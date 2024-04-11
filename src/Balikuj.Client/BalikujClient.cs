/*
* Copyright (c) 2024 Balíkuj.cz
* http://www.balikuj.cz
* Ing. Petr Rympler
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

using Balikuj.Client.Configuration;
using Balikuj.Client.Exceptions;
using Balikuj.Client.Models.Account;
using Balikuj.Client.Models.Addresses;
using Balikuj.Client.Models.Webhooks;
using Balikuj.Client.Results;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Balikuj.Client
{
    public class BalikujClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions() { 
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };


        /// <summary>
        /// Default constructor for dependency injection with HttpClient
        /// </summary>
        /// <param name="httpClient"></param>
        public BalikujClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        private string _apiKey { get; set; }

        public string ApiKey { get { return _apiKey; } private set { } }



        #region Public Methods


        /// <summary>
        /// Set current API key
        /// </summary>
        /// <param name="apiKey"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void SetApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey), "ApiKey");

            _apiKey = apiKey;
        }


        /// <summary>
        /// Login to Balikuj API with specified credentials. If you have existing apiKey, you can use it to authenticate.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<ApiResult<AccountLoginResponse>> AccountLogin(AccountLoginRequest model)
        {
            if (string.IsNullOrWhiteSpace(model.Email))
                throw new ArgumentNullException(nameof(model.Email), "Email is required");

            if (string.IsNullOrWhiteSpace(model.Password))
                throw new ArgumentNullException(nameof(model.Password), "Password is required");

            if (string.IsNullOrWhiteSpace(model.Language))
                throw new ArgumentNullException(nameof(model.Language), "Language is required");

            var httpRequest = CreateRequest("Account/Login", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<AccountLoginResponse>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<bool>> AccountLogout()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Account/Logout", HttpMethod.Post);
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<bool>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<AccountInfoResponse>> AccountInfo()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Account/Info", HttpMethod.Get);
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<AccountInfoResponse>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<AccountInfoResponse>> AccountInfoUpdate(AccountInfoUpdateRequest model)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Account/Info", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<AccountInfoResponse>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }

        #endregion


        #region Address

        public async Task<ApiResult<AddressListResponse>> AddressList(AddressListRequest model)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Address/Find", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<AddressListResponse>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<Address>> AddressGet(int id)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"Address/{id}", HttpMethod.Get);

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<Address>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<Address>> AddressCreate(AddressCreateRequest model)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Address", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<Address>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<bool> AddressDelete(int id)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"Address/{id}", HttpMethod.Delete);

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            return httpResponse.IsSuccessStatusCode;
        }


        #endregion


        #region Webhook
        
        public async Task<ApiResult<AddressListResponse>> WebhookList()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Webhook/Find", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(new { }), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<AddressListResponse>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }






        public async Task<ApiResult<List<WebhookEvent>>> WebhookEvents()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Webhook/Events", HttpMethod.Get);

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<List<WebhookEvent>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        /*
         WebhookList
         WebhookGet
         WebhookCreate
         WebhookUpdate
         WebhookDelete
         WebhookEvents
         */
        #endregion



        #region Private Methods

        private HttpRequestMessage CreateRequest(string endpoint, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Login is required to send data");

            var requestUrl = GetApiUrl(endpoint);

            var request = new HttpRequestMessage(method, requestUrl);
            request.Headers.Add(BalikujSettings.ApiHeaderName, _apiKey);

            return request;
        }

        private string GetApiUrl(string endpoint)
        {
            var apiUrl = BalikujSettings.ApiBaseUrl;
            if (!string.IsNullOrEmpty(BalikujSettings.ApiVersion))
                apiUrl += $"/{BalikujSettings.ApiVersion}";

            apiUrl += $"/{endpoint}";

            return apiUrl;
        }

        #endregion
    }
}
