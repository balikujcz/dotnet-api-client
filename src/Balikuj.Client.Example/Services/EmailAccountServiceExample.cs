using Balikuj.Client.Models.EmailAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class EmailAccountServiceExample
    {
        private readonly BalikujClient _client;

        public EmailAccountServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            /////////////////////
            /// Email list
            /////////////////////
            
            /*
            Console.WriteLine("Getting email accounts ...");
            var emailList = await _client.EmailList();
            Console.WriteLine($"EmailList StatusCode = {emailList.StatusCode}, count = {emailList?.Result?.Total}");
            */


            /////////////////////
            /// Email create
            //////////////////////
            
            /*
            var newEmail = new EmailAccount
            {
                Id = 0,
                Email = "josefnovak2@email.cz",
                DisplayName = "Josef Novák",
                Host = "smtp.email.cz",
                Port = 587,
                Username = "josefnovak",
                Password = "heslo",
                EnableSsl = true,
                IsDefaultEmailAccount = true
            };

            Console.WriteLine("Creating email account ...");
            var emailCreate = await _client.EmailCreate(newEmail);
            Console.WriteLine($"EmailCreate StatusCode = {emailCreate.StatusCode}, result = {emailCreate?.Result}");
            */


            /////////////////////
            /// Email mark as default
            /////////////////////
            
            /*
            int emailId = 2;

            Console.WriteLine("Creating email account ...");
            var emailMarkedAsDefault = await _client.EmailMarkAsDefault(emailId);
            Console.WriteLine($"EmailCreate StatusCode = {emailMarkedAsDefault.StatusCode}, result = {emailMarkedAsDefault?.Result}");
            */

            /////////////////////
            /// Email update
            /////////////////////
            
            /*
            var updateEmailModel = new EmailAccount
            {
                Id = 2,
                Email = "josefnovak@email.cz",
                DisplayName = "Josef Novák",
                Host = "smtp.email.cz",
                Port = 587,
                Username = "josefnovak",
                Password = "heslo",
                EnableSsl = false,
                IsDefaultEmailAccount = false
            };

            Console.WriteLine("Updating email account ...");
            var updatedEmal = await _client.EmailUpdate(updateEmailModel);
            Console.WriteLine($"EmailCreate StatusCode = {updatedEmal.StatusCode}, result = {updatedEmal?.Result}");
            */


            /////////////////////
            /// Email delete
            /////////////////////
            

            /*
            int emailId = 5;

            Console.WriteLine("Creating email account ...");
            var emailDelete = await _client.EmailDelete(emailId);
            Console.WriteLine($"EmailCreate StatusCode = {emailDelete.StatusCode}, result = {emailDelete?.Result}");
            */


            /////////////////////
            /// Email test send
            /////////////////////

            /*
            var emailTestModel = new EmailAccountTestModel
            {
                Id = 2,
                SendToEmail = "email@email.cz"
            };

            Console.WriteLine("Sending testing email account ...");
            var emailTestSend = await _client.EmailSendTest(emailTestModel);
            Console.WriteLine($"EmailSendTest StatusCode = {emailTestSend.StatusCode}, result = {emailTestSend?.Result}");
            */
        }
    }
}
