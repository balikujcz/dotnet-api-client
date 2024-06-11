using Balikuj.Client.Clients.Base;
using Balikuj.Client.Clients.Carrier.Base;
using Balikuj.Client.Exceptions;
using Balikuj.Client.Models.Carrier;
using Balikuj.Client.Results;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Balikuj.Client.Clients.Carrier
{
    public class CarrierClient : BaseClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public CarrierClient(HttpClient httpClient, string apiKey) : base(apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        // Česká pošta
        private BaseCarrierClient _cpClient;
        public BaseCarrierClient Cp
        {
            get
            {
                if (_cpClient == null)
                    _cpClient = new BaseCarrierClient(_httpClient, _apiKey, CarriersEnum.Cp);

                return _cpClient;
            }
        }

        // DPD
        private BaseCarrierClient _dpdClient;
        public BaseCarrierClient Dpd
        {
            get
            {
                if (_dpdClient == null)
                    _dpdClient = new BaseCarrierClient(_httpClient, _apiKey, CarriersEnum.Dpd);

                return _dpdClient;
            }
        }


        // GEIS
        private BaseCarrierClient _geisClient;
        public BaseCarrierClient Geis
        {
            get
            {
                if (_geisClient == null)
                    _geisClient = new BaseCarrierClient(_httpClient, _apiKey, CarriersEnum.Geis);

                return _geisClient;
            }
        }


        // GLS
        private BaseCarrierClient _glsClient;
        public BaseCarrierClient Gls
        {
            get
            {
                if (_glsClient == null)
                    _glsClient = new BaseCarrierClient(_httpClient, _apiKey, CarriersEnum.Gls);

                return _glsClient;
            }
        }


        public async Task<ApiResult<IEnumerable<CarrierListResponse>>> List()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Carrier/Find", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(new { }), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<IEnumerable<CarrierListResponse>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<IEnumerable<CarrierServiceModel>>> Services(CarrierServiceSearchModel model)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Carrier/Services", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<IEnumerable<CarrierServiceModel>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }


        public async Task<ApiResult<IEnumerable<CarrierManipulationUnit>>> ManipulationUnits(CarrierManipulationUnitSearchModel model)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new BalikujException("Account is not logged in, login is required");

            var httpRequest = CreateRequest("Carrier/ManipulationUnits", HttpMethod.Post);
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.SendAsync(httpRequest);

            var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<ApiResult<IEnumerable<CarrierManipulationUnit>>>(responseStream, _jsonSerializerOptions);

            response.StatusCode = (int)httpResponse.StatusCode;
            return response;
        }
    }
}
