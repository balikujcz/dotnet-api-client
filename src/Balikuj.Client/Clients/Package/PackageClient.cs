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
using Balikuj.Client.Models.Package;
using Balikuj.Client.Results;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Balikuj.Client.Clients.Package
{
    public class PackageClient : BaseClient
    {
        private readonly HttpClient _httpClient;

        public PackageClient(HttpClient httpClient, string apiKey) : base(apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }


        public async Task<ApiResult<PackageListResponse>> List()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Package/Find", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(new { }), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<PackageListResponse>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<IEnumerable<PackageOrderInfoModel>>> NotOrderedInfo()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Package/NotOrderedInfo", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(new { }), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<IEnumerable<PackageOrderInfoModel>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }
        
        
        public async Task<ApiResult<PackageActivityListModel>> Activity(PackageActivitySearchModel model)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Package/Activity", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<PackageActivityListModel>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<IEnumerable<PackageTrackingStatusCore>>> TrackingStatus()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Package/TrackingStatus", HttpMethod.Get);

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<IEnumerable<PackageTrackingStatusCore>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }

    }
}
