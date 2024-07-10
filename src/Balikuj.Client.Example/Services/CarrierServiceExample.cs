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

using Balikuj.Client.Models.Carrier;

namespace Balikuj.Client.Example.Services
{
    public class CarrierServiceExample
    {
        private readonly BalikujClient _client;

        public CarrierServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {

            /////////////////////////
            /// Carrier List
            ///////////////////////// 
            
            Console.WriteLine("Getting carriers ...");
            var carrierList = await _client.Carrier.List();
            Console.WriteLine($"CarrierList StatusCode = {carrierList.StatusCode}, result = {carrierList?.Result?.ToList().Count}");
            

            /////////////////////////
            /// Carrier service list
            ///////////////////////// 
            
            var serviceSearch = new CarrierServiceSearchModel
            {
                 CarrierCode = "PPL"
            };

            Console.WriteLine("Getting carriers services ...");
            var carrierServices = await _client.Carrier.Services(serviceSearch);
            Console.WriteLine($"CarrierList StatusCode = {carrierServices.StatusCode}, items = {carrierServices?.Result?.ToList().Count}");
            

            //////////////////////////////
            /// Carrier Manipulation Units
            /////////////////////////////
            
            
            var manipulationSearch = new CarrierManipulationUnitSearchModel
            {
                CarrierCode = "GEIS"
            };

            Console.WriteLine("Getting carrier manipulation units ...");
            var manipulationUnits = await _client.Carrier.ManipulationUnits(manipulationSearch);
            Console.WriteLine($"CarrierManipulationUnits StatusCode = {manipulationUnits.StatusCode}, items = {manipulationUnits?.Result?.Count()}");
            
        }
    }
}
