using Balikuj.Client.Configuration;
using Balikuj.Client.Exceptions;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;

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

        private string _apiKey;

        public BaseClient(string apiKey)
        {
            _apiKey = apiKey;
        }


        protected HttpRequestMessage CreateRequest(string endpoint, HttpMethod method, string query = null)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Login is required to send data");

            var requestUrl = GetApiUrl(endpoint);

            if (!string.IsNullOrEmpty(query))
                requestUrl += $"?{query}";

            var request = new HttpRequestMessage(method, requestUrl);
            request.Headers.Add(BalikujSettings.ApiHeaderName, _apiKey);

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
