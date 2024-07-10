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
using Balikuj.Client.Models.Label;
using Balikuj.Client.Results;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Balikuj.Client.Clients.Label
{
    public class LabelClient : BaseClient
    {
        private readonly HttpClient _httpClient;

        public LabelClient(HttpClient httpClient, string apiKey) : base(apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public async Task<ApiResult<List<LabelModel>>> NotPrinted(LabelType labelType)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            HttpRequestMessage httpRequest;

            if (labelType == LabelType.Zpl)
            {
                httpRequest = CreateRequest("Label/NotPrinted", HttpMethod.Post, labelType.ToString());

            }
            else
            {
                httpRequest = CreateRequest("Label/NotPrinted", HttpMethod.Post);
            }

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<List<LabelModel>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<IEnumerable<LabelModel>>> Print(LabelPackageModel model, string type)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"Label/Print?type={type}", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<IEnumerable<LabelModel>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<IEnumerable<LabelModel>>> PrintOrders(LabelOrderModel model, string type)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"Label/PrintOrders?type={type}", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<ApiResult<IEnumerable<LabelModel>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }
    }
}
