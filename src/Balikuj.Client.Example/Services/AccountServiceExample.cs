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

using Balikuj.Client.Models.Account;
using System.Net;

namespace Balikuj.Client.Example.Services
{
    public class AccountServiceExample
    {
        private readonly BalikujClient _client;

        public AccountServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {

            ///////////////
            /// Account Login
            //////////////
            
            
            var loginModel = new AccountLoginRequest
            {
                Email = "info@email.cz",
                Password = "pass",
                Language = "cs-CZ",
                Code = null
            };


            Console.WriteLine("Logging in ...");
            var accountLogin = await _client.Account.LoginAsync(loginModel);
            Console.WriteLine($"Login StatusCode = {accountLogin.StatusCode}, Expires in = {accountLogin?.Result.ExpiresIn}");

            if (accountLogin?.StatusCode == (int)HttpStatusCode.OK)
            {
                Console.WriteLine($"AuthToken = {accountLogin?.Result.AuthToken}");
                _client.SetApiKey(accountLogin?.Result.AuthToken);
            }

            
            //////////////////
            /// Account Logout
            //////////////////
            
            
            Console.WriteLine("Logging out ...");
            var accountLogout = await _client.Account.LogoutAsync();
            Console.WriteLine($"Logout StatusCode = {accountLogout.StatusCode}, Success = {accountLogout?.Result}");
            


            ///////////////
            /// Account Info
            //////////////
            

            Console.WriteLine("Getting account info ...");
            var accountInfo = await _client.Account.InfoAsync();
            Console.WriteLine($"Info StatusCode = {accountInfo.StatusCode}, Success = {accountInfo?.Result}");
            

            ///////////////
            /// Account Info Update
            //////////////

            
            var infoUpdateModel = new AccountInfoUpdateRequest
            {
                Email = "info@newemail.cz",
                Phone = "123456789",
                Company = "Company",
                Street = "Street",
                City = "City",
                Zip = "12345",
                Country = "CZ",
                FullName = "Full Name",
                TimeZone = "Central Europe Standard Time"
            };
            

            Console.WriteLine("Updating account info ...");
            var updateAccount = await _client.Account.InfoUpdateAsync(infoUpdateModel);
            Console.WriteLine($"InfoUpdate StatusCode = {updateAccount.StatusCode}, Success = {updateAccount?.Result}");
           
        }

    }
}
