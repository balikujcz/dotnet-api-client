/*
* Copyright (c) 2024 Balíkuj.cz
* http://balikuj.cz
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

using Balikuj.Client.Clients.Base;
using Balikuj.Client.Exceptions;
using Balikuj.Client.Models.Account;
using Balikuj.Client.Results;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Balikuj.Client.Clients.Account
{
    public class AccountClient : BaseClient
    {
        private readonly HttpClient _httpClient;

        public AccountClient(HttpClient httpClient, string apiKey) : base(apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        /// <summary>
        /// Login to Balikuj API with specified credentials. If you have existing apiKey, you can use it to authenticate.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<ApiResult<AccountLoginResponse>> LoginAsync(AccountLoginRequest model)
        {
            if (string.IsNullOrWhiteSpace(model.Email))
                throw new ArgumentNullException(nameof(model.Email), "Email is required");

            if (string.IsNullOrWhiteSpace(model.Password))
                throw new ArgumentNullException(nameof(model.Password), "Password is required");

            if (string.IsNullOrWhiteSpace(model.Language))
                throw new ArgumentNullException(nameof(model.Language), "Language is required");


            var httpRequest = CreateRequest("Account/Login", HttpMethod.Post, null, false);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<ApiResult<AccountLoginResponse>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;

            if (response.StatusCode == 200)
            {
                SetApiKey(response.Result.AuthToken);
            }

            return response;
        }


        public async Task<ApiResult<bool>> LogoutAsync()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Account/Logout", HttpMethod.Post);
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<ApiResult<bool>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<AccountInfoResponse>> InfoAsync()
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


        public async Task<ApiResult<AccountInfoResponse>> InfoUpdateAsync(AccountInfoUpdateRequest model)
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
    }
}
