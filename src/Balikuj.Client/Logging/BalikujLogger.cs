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

using Balikuj.Client.Clients.Carrier;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;

namespace Balikuj.Client.Logging
{
    public class BalikujLogger<T, R>
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
