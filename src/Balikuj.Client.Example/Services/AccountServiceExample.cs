using Balikuj.Client.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    internal class AccountServiceExample
    {
        private readonly BalikujClient _client;

        public AccountServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {

            ///////////////
            /// Account Login
            //////////////
            ///
            /*
            var model = new AccountLoginRequest
            {
                Email = "info@email.cz",
                Password = "password",
                Language = "cs-CZ",
                Code = null
            };


            Console.WriteLine("Logging in ...");
            var account = await _client.Account.LoginAsync(model);
            Console.WriteLine($"Login StatusCode = {account.StatusCode}, Expires in = {account?.Result.ExpiresIn}");
            */


            ///////////////
            /// Account Logout
            //////////////
            ///

            /*
            Console.WriteLine("Logging out ...");
            var account = await _client.Account.LogoutAsync();
            Console.WriteLine($"Logout StatusCode = {account.StatusCode}, Success = {account?.Result}");
            */


            ///////////////
            /// Account Info
            //////////////
            ///
            /*

            Console.WriteLine("Getting account info ...");
            var account = await _client.Account.InfoAsync();
            Console.WriteLine($"Info StatusCode = {account.StatusCode}, Success = {account?.Result}");
            */


            ///////////////
            /// Account Info Update
            //////////////
            ///

            /*
            var model = new AccountInfoUpdateRequest
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
            var account = await _client.Account.InfoUpdateAsync(model);
            Console.WriteLine($"InfoUpdate StatusCode = {account.StatusCode}, Success = {account?.Result}");
            */




        }

    }
}
