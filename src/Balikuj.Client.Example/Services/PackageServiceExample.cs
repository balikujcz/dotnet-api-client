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

using Balikuj.Client.Models.Package;

namespace Balikuj.Client.Example.Services
{
    public class PackageServiceExample
    {

        private readonly BalikujClient _client;

        public PackageServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {
            ////////////////////////
            /// Package list
            /////////////////////////
            
            var model = new PackageSearchModel
            {
                PageSize = 50
            };

            
            Console.WriteLine("Getting packages ...");
            var packageList = await _client.Package.List(model);
            Console.WriteLine($"PackageList StatusCode = {packageList.StatusCode}, items = {packageList?.Result?.Total}");
            


            ////////////////////////
            /// Package not ordered info
            /////////////////////////

            
            Console.WriteLine("Getting packages ...");
            var packageNotOrdered = await _client.Package.NotOrderedInfo();
            Console.WriteLine($"PackageNotOrderedInfo StatusCode = {packageNotOrdered.StatusCode}, items = {packageNotOrdered?.Result.Count()}");
            


            ////////////////////////
            /// Package activity
            /////////////////////////
            
            
            var packageActivitySearchModel = new PackageActivitySearchModel
            {
                Search = "1"
            };
           
            Console.WriteLine("Getting packages activity ...");
            var packageActivity = await _client.Package.Activity(packageActivitySearchModel);
            Console.WriteLine($"PackageActivity StatusCode = {packageActivity.StatusCode}, items = {packageActivity?.Result?.Total}");
            


            ////////////////////////
            /// Package tracking status
            /////////////////////////
           
            
            Console.WriteLine("Getting packages trackign statuses ...");
            var packageTrackignStatus = await _client.Package.TrackingStatus();
            Console.WriteLine($"PackageTrackingStatus StatusCode = {packageTrackignStatus.StatusCode}, items = {packageTrackignStatus?.Result?.Count()}");
            
        }
    }
}
