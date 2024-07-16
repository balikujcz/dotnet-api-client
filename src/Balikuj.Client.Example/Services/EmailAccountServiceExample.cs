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

using Balikuj.Client.Models.EmailAccount;

namespace Balikuj.Client.Example.Services
{
    public class EmailAccountServiceExample
    {
        private readonly BalikujClient _client;

        public EmailAccountServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {
            /////////////////////
            /// Email list
            /////////////////////
            
            var emailAccountSearchModel = new EmailAccountSearchModel
            {
                PageSize = 50
            };

            Console.WriteLine("Getting email accounts ...");
            var emailList = await _client.EmailAccount.List(emailAccountSearchModel);
            Console.WriteLine($"EmailList StatusCode = {emailList.StatusCode}, count = {emailList?.Result?.Total}");
            


            /////////////////////
            /// Email create
            //////////////////////
            
            
            var newEmail = new EmailAccountModel
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
            var emailCreate = await _client.EmailAccount.Create(newEmail);
            Console.WriteLine($"EmailCreate StatusCode = {emailCreate.StatusCode}, result = {emailCreate?.Result}");
            


            /////////////////////
            /// Email mark as default
            /////////////////////
            
            
            int emailId = 2;

            Console.WriteLine("Creating email account ...");
            var emailMarkedAsDefault = await _client.EmailAccount.MarkAsDefault(emailId);
            Console.WriteLine($"EmailCreate StatusCode = {emailMarkedAsDefault.StatusCode}, result = {emailMarkedAsDefault?.Result}");
            

            /////////////////////
            /// Email update
            /////////////////////
            
            
            var updateEmailModel = new EmailAccountModel
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
            var updatedEmal = await _client.EmailAccount.Update(updateEmailModel);
            Console.WriteLine($"EmailCreate StatusCode = {updatedEmal.StatusCode}, result = {updatedEmal?.Result}");
            
            

            /////////////////////
            /// Email delete
            /////////////////////
            
            // int emailId = 5;

            Console.WriteLine("Creating email account ...");
            var emailDelete = await _client.EmailAccount.Delete(emailId);
            Console.WriteLine($"EmailCreate StatusCode = {emailDelete.StatusCode}, result = {emailDelete?.Result}");
            


            /////////////////////
            /// Email test send
            /////////////////////

            
            var emailTestModel = new EmailAccountTestModel
            {
                Id = 2,
                SendToEmail = "email@email.cz"
            };

            Console.WriteLine("Sending testing email account ...");
            var emailTestSend = await _client.EmailAccount.SendTest(emailTestModel);
            Console.WriteLine($"EmailSendTest StatusCode = {emailTestSend.StatusCode}, result = {emailTestSend?.Result}");
            
        }
    }
}
