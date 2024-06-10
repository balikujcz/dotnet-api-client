using Balikuj.Client.Clients.Base;
using Balikuj.Client.Clients.Carrier.Base;
using System.Net.Http;

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


        // GEIS


        // GLS
    }
}
