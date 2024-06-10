using Balikuj.Client.Clients.Base;
using Balikuj.Client.Exceptions;
using Balikuj.Client.Models.Carrier.Base;
using Balikuj.Client.Models.Package;
using Balikuj.Client.Results;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace Balikuj.Client.Clients.Carrier.Base
{
    public class BaseCarrierClient : BaseClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly CarriersEnum _carrier;

        public BaseCarrierClient(HttpClient client, string apiKey, CarriersEnum carrier) : base(apiKey)
        {
            _httpClient = client;
            _apiKey = apiKey;
            _carrier = carrier;
        }

        public async Task<PackageCreateResultModel<PackageCreateModel>> CreateAsync<T>(IList<T> packages) where T : IAddPackageModel
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"{_carrier.ToString()}/Create", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(packages), System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<PackageCreateResultModel<PackageCreateModel>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }

        public async Task<ApiResult<IList<T>>> GetAsync<T>(int id) where T : class
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"{_carrier.ToString()}/{id}", HttpMethod.Get);
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<IList<T>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }
    }
}
