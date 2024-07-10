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

using Balikuj.Client.Models.EmailTemplate;

namespace Balikuj.Client.Example.Services
{
    public class EmailTemplateServiceExample
    {
        private readonly BalikujClient _client;

        public EmailTemplateServiceExample(BalikujClient client)
        {
            _client = client;
        }

        public async Task RunAsync()
        {
            ///////////////////////
            /// Email template find
            ///////////////////////
            
            
            Console.WriteLine("Finding email templates ...");
            var emailTemplates = await _client.EmailTemplate.List();
            Console.WriteLine($"EmailTemplateList StatusCode = {emailTemplates.StatusCode}, result = {emailTemplates?.Result?.Total}");
            


            /////////////////////////
            /// Email template update
            /////////////////////////

            
            var updateModel = new MessageTemplate
            {
                Id = 6,
                DelayPeriodId = 1,
                DelayBeforeSend = 0,
                IsActive = true,
                Name = "Test template 2",
                Subject = "Test subject",
                Body = "Test body updated",
                AllowedTokens = "test",
                BccEmailAddresses = "email@email.cz",
                SendImmediately = true,
                HasAttachedDownload = false,
                AttachedDownloadName = "",
                EmailAccountId = 1

            };

            Console.WriteLine("Updating email template ...");
            var updatedTemplate = await _client.EmailTemplate.Update(updateModel);
            Console.WriteLine($"EmailTemplateUpdate StatusCode = {updatedTemplate.StatusCode}, result = {updatedTemplate?.Result}");
            

            /////////////////////////
            /// Email template create
            /////////////////////////

            
            var createModel = new MessageTemplate
            {
                DelayPeriodId = 1,
                DelayBeforeSend = 0,
                IsActive = true,
                Name = "Test template 2",
                Subject = "Test subject",
                Body = "Test body",
                AllowedTokens = "test",
                BccEmailAddresses = "email@email.cz",
                SendImmediately = true,
                HasAttachedDownload = false,
                AttachedDownloadName = "",
                EmailAccountId = 1
             
            };

            Console.WriteLine("Updating email template ...");
            var createdTemplate = await _client.EmailTemplate.Create(createModel);
            Console.WriteLine($"EmailTemplateCreate StatusCode = {createdTemplate.StatusCode}, result = {createdTemplate?.Result}");
            


            //////////////////////////
            /// Email template delete
            //////////////////////////

            
            int templateId = 6;

            Console.WriteLine("Deleting email template ...");
            var deletedTemplate = await _client.EmailTemplate.Delete(templateId);
            Console.WriteLine($"EmailTemplateDelete StatusCode = {deletedTemplate.StatusCode}, result = {deletedTemplate?.Result}");
            

        }
    }
}
