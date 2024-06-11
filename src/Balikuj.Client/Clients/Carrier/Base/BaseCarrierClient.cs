using Balikuj.Client.Clients.Base;
using Balikuj.Client.Exceptions;
using Balikuj.Client.Logging;
using Balikuj.Client.Models.Carrier.Base;
using Balikuj.Client.Models.Package;
using Balikuj.Client.Models.Pickup;
using Balikuj.Client.Results;
using System.Collections.Generic;
using System.IO;
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
        private readonly string filePath = "C:\\WEB\\dotnet-api-client\\src\\Balikuj.Client\\log.txt";

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

            var responseStream = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<PackageCreateResultModel<PackageCreateModel>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;

            var myWriter = new MyLogger<IList<T>, PackageCreateResultModel<PackageCreateModel>>();
            myWriter.Write(httpRequest, httpResponse, packages, response, _carrier, filePath);

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

            var myWriter = new MyLogger<IList<T>, ApiResult<IList<T>>>();
            myWriter.Write(httpRequest, httpResponse, null, response, _carrier, filePath);

            return response;
        }

        public async Task<ApiResult<PickupOrderResultModel>> Order<T>(PickupOrderModel model) where T : class
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"{_carrier.ToString()}/Order", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<ApiResult<PickupOrderResultModel>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;

            var myWriter = new MyLogger<PickupOrderModel, ApiResult<PickupOrderResultModel>>();
            myWriter.Write(httpRequest, httpResponse, model, response, _carrier, filePath);

            return response;
        }


        public async Task<ApiResult<IEnumerable<PackageCancelResultModel>>> Cancel<T>(PackageCancelModel model) where T : class
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest($"{_carrier.ToString()}/Cancel", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<ApiResult<IEnumerable<PackageCancelResultModel>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;

            var myWriter = new MyLogger<PackageCancelModel, ApiResult<IEnumerable<PackageCancelResultModel>>>();
            myWriter.Write(httpRequest, httpResponse, model, response, _carrier, filePath);

            return response;
        }
    }
}
