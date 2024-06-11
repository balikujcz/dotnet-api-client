/*
* Copyright (c) 2024 Balíkuj.cz
* http://www.balikuj.cz
* Ing. Petr Rympler
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

using Balikuj.Client.Clients.Account;
using Balikuj.Client.Clients.Address;
using Balikuj.Client.Clients.Application;
using Balikuj.Client.Clients.Carrier;
using Balikuj.Client.Clients.EmailAccount;
using Balikuj.Client.Clients.EmailTemplate;
using Balikuj.Client.Clients.Label;
using Balikuj.Client.Clients.Order;
using Balikuj.Client.Clients.Package;
using Balikuj.Client.Clients.Picking;
using Balikuj.Client.Clients.Pickup;
using Balikuj.Client.Clients.Printer;
using Balikuj.Client.Clients.Rule;
using Balikuj.Client.Clients.Webhook;
using Balikuj.Client.Configuration;
using Balikuj.Client.Exceptions;
using Balikuj.Client.Models.Addresses;
using Balikuj.Client.Models.Application;
using Balikuj.Client.Models.Carrier;
using Balikuj.Client.Models.Carrier.Cp;
using Balikuj.Client.Models.EmailAccount;
using Balikuj.Client.Models.EmailTemplate;
using Balikuj.Client.Models.Label;
using Balikuj.Client.Models.Order;
using Balikuj.Client.Models.Picking;
using Balikuj.Client.Models.Pickup;
using Balikuj.Client.Models.Printer;
using Balikuj.Client.Models.Rule;
using Balikuj.Client.Models.Webhooks;
using Balikuj.Client.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Balikuj.Client
{
    public class BalikujClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions() { 
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter() }
        };


        /// <summary>
        /// Default constructor for dependency injection with HttpClient
        /// </summary>
        /// <param name="httpClient"></param>
        public BalikujClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        private string _apiKey { get; set; }

        public string ApiKey { get { return _apiKey; } private set { } }



        #region Public Methods


        /// <summary>
        /// Set current API key
        /// </summary>
        /// <param name="apiKey"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void SetApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey), "ApiKey");

            _apiKey = apiKey;
        }


        #endregion


        
        // Account
        private AccountClient _accountClient;
        public AccountClient Account
        {
            get
            {
                if (_accountClient == null)
                    _accountClient = new AccountClient(_httpClient, _apiKey);

                return _accountClient;
            }
        }


        // Address
        private AddressClient _addressClient;
        public AddressClient Address
        {
           get
            {
                if (_addressClient == null)
                    _addressClient = new AddressClient(_httpClient, _apiKey);

                return _addressClient;
            }
        }


        // Application

        private ApplicationClient _applicationClient;
        public ApplicationClient Application
        {
            get
            {
                if (_applicationClient == null)
                    _applicationClient = new ApplicationClient(_httpClient, _apiKey);

                return _applicationClient;
            }
        }


        // EmailAccount
        private EmailAccountClient _emailAccountClient;
        public EmailAccountClient EmailAccount
        {
            get
            {
                if (_emailAccountClient == null)
                    _emailAccountClient = new EmailAccountClient(_httpClient, _apiKey);

                return _emailAccountClient;
            }
        }


        // EmailTemplate
        private EmailTemplateClient _emailTemplateClient;
        public EmailTemplateClient EmailTemplate
        {
            get
            {
                if (_emailTemplateClient == null)
                    _emailTemplateClient = new EmailTemplateClient(_httpClient, _apiKey);

                return _emailTemplateClient;
            }
        }

        // Order
        private OrderClient _orderClient;
        public OrderClient Order
        {
            get
            {
                if (_orderClient == null)
                    _orderClient = new OrderClient(_httpClient, _apiKey);

                return _orderClient;
            }
        }


        // Package
        private PackageClient _packageClient;
        public PackageClient Package
        {
            get
            {
                if (_packageClient == null)
                    _packageClient = new PackageClient(_httpClient, _apiKey);

                return _packageClient;
            }
        }


        // Picking
        private PickingClient _pickingClient;
        public PickingClient Picking
        {
            get
            {
                if (_pickingClient == null)
                    _pickingClient = new PickingClient(_httpClient, _apiKey);

                return _pickingClient;
            }
        }


        // Pickup
        private PickupClient _pickupClient;
        public PickupClient Pickup
        {
            get
            {
                if (_pickupClient == null)
                    _pickupClient = new PickupClient(_httpClient, _apiKey);

                return _pickupClient;
            }
        }


        // Label
        private LabelClient _labelClient;
        public LabelClient Label
        {
            get
            {
                if (_labelClient == null)
                    _labelClient = new LabelClient(_httpClient, _apiKey);

                return _labelClient;
            }
        }


        // Printer
        private PrinterClient _printerClient;
        public PrinterClient Printer
        {
            get
            {
                if (_printerClient == null)
                    _printerClient = new PrinterClient(_httpClient, _apiKey);

                return _printerClient;
            }
        }


        // Rule
        private RuleClient _ruleClient;
        public RuleClient Rule
        {
            get
            {
                if (_ruleClient == null)
                    _ruleClient = new RuleClient(_httpClient, _apiKey);

                return _ruleClient;
            }
        }


        // Webhook
        private WebhookClient _webhookClient;
        public WebhookClient Webhook
        {
            get
            {
                if (_webhookClient == null)
                    _webhookClient = new WebhookClient(_httpClient, _apiKey);

                return _webhookClient;
            }
        }

        // Carrier
        //private CarrierClient _carrierClient;
        //public CarrierClient Carrier
        //{
        //    get
        //    {
        //        if (_carrierClient == null)
        //            _carrierClient = new CarrierClient(_httpClient, _apiKey);

        //        return _carrierClient;
        //    }
        //}

        private CarrierClient _carrierClient;
        public CarrierClient Carrier => _carrierClient ?? (_carrierClient = new CarrierClient(_httpClient, _apiKey));

        // var query = await _client.Carrier.Cp.GetAsync<AddPackageCpModel>(10);

        // var createResult = await _client.Carrier.Cp.CreateAsync([new AddPackageCpModel { RecName = "František Hromek", RecStreet = "Vavrečkova 7074", ServiceType = "DR" }]);




        
     
        #region Carriers


        #region CP


        


        #endregion

        #endregion






        #region Private Methods

        private HttpRequestMessage CreateRequest(string endpoint, HttpMethod method, string query = null)
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

        private string GetApiUrl(string endpoint)
        {
            var apiUrl = BalikujSettings.ApiBaseUrl;
            if (!string.IsNullOrEmpty(BalikujSettings.ApiVersion))
                apiUrl += $"/{BalikujSettings.ApiVersion}";

            apiUrl += $"/{endpoint}";

            return apiUrl;
        }

        #endregion
    }
}
