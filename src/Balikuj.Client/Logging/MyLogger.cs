using Balikuj.Client.Clients.Carrier;
using Balikuj.Client.Models.Package;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Cache;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace Balikuj.Client.Logging
{
    public class MyLogger<T, R>
    {

        public void Write(HttpRequestMessage httpRequest, HttpResponseMessage httpResponse, T model, R response, CarriersEnum carrier, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true, DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull };

            var requestDetails = new
            {
                RequestUri = httpRequest.RequestUri.ToString(),
                RequestMethod = httpRequest.Method.ToString(),
                RequestHeaders = httpRequest.Headers.ToString(),
            };

            var requestContent = new
            {
                RequestContent = model
            };

            var responseDetails = new
            {
                ResponseStatusCode = httpResponse.StatusCode,
                ResponseHeaders = httpResponse.Headers.ToString(),
                ResponseContent = response
            };

            var methodDetails = new
            {
                Carrier = carrier.ToString(),
                Method = MethodBase.GetCurrentMethod().Name
            };

            var logEntry = new
            {
                CallDetails = methodDetails,
                RequestDetails = requestDetails,
                RequestContent = requestContent,
                Response = responseDetails,
            };


            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                JsonSerializer.Serialize(fileStream, logEntry, options);
            }
        }
    }
}
