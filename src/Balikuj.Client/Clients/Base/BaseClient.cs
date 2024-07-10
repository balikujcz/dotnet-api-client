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

using Balikuj.Client.Configuration;
using Balikuj.Client.Exceptions;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Clients.Base
{
    public class BaseClient
    {
        protected readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter() }
        };

        protected string _apiKey;

        public BaseClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public void SetApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey), "ApiKey");

            _apiKey = apiKey;
        }



        protected HttpRequestMessage CreateRequest(string endpoint, HttpMethod method, string query = null, bool checkApiKey = true)
        {
            if (string.IsNullOrWhiteSpace(_apiKey) && checkApiKey)
                throw new BalikujException("Login is required to send data");

            var requestUrl = GetApiUrl(endpoint);

            if (!string.IsNullOrEmpty(query)) 
                requestUrl += $"?{query}";

            var request = new HttpRequestMessage(method, requestUrl);
            
            if (checkApiKey)
            {
                request.Headers.Add(BalikujSettings.ApiHeaderName, _apiKey);
            }

            return request;
        }


        protected string GetApiUrl(string endpoint)
        {
            var apiUrl = BalikujSettings.ApiBaseUrl;
            if (!string.IsNullOrEmpty(BalikujSettings.ApiVersion))
                apiUrl += $"/{BalikujSettings.ApiVersion}";

            apiUrl += $"/{endpoint}";

            return apiUrl;
        }
    }
}
