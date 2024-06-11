using Balikuj.Client.Clients.Base;
using Balikuj.Client.Exceptions;
using Balikuj.Client.Models.Label;
using Balikuj.Client.Results;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Balikuj.Client.Clients.Label
{
    public class LabelClient : BaseClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public LabelClient(HttpClient httpClient, string apiKey) : base(apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        // TODO FEW METHODS

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
    }
}
