using Balikuj.Client.Models.EmailTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balikuj.Client.Example.Services
{
    public class EmailTemplateServiceExample
    {
        private readonly BalikujClient _client;

        public EmailTemplateServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            ///////////////////////
            /// Email template find
            ///////////////////////

            /*
            Console.WriteLine("Finding email templates ...");
            var emailTemplates = await _client.EmailTemplateList();
            Console.WriteLine($"EmailCreate StatusCode = {emailTemplates.StatusCode}, result = {emailTemplates?.Result?.Total}");
            */


            /////////////////////////
            /// Email template update
            /////////////////////////

            /*
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
            var updatedTemplate = await _client.EmailTemplateUpdate(updateModel);
            Console.WriteLine($"EmailCreate StatusCode = {updatedTemplate.StatusCode}, result = {updatedTemplate?.Result}");
            */

            /////////////////////////
            /// Email template create
            /////////////////////////

            /*
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
            var createdTemplate = await _client.EmailTemplateCreate(createModel);
            Console.WriteLine($"EmailCreate StatusCode = {createdTemplate.StatusCode}, result = {createdTemplate?.Result}");
            */


            //////////////////////////
            /// Email template delete
            //////////////////////////

            /*
            int templateId = 6;

            Console.WriteLine("Deleting email template ...");
            var deletedTemplate = await _client.EmailTemplateDelete(templateId);
            Console.WriteLine($"EmailCreate StatusCode = {deletedTemplate.StatusCode}, result = {deletedTemplate?.Result}");
            */



            //////////////////////////
            /// Email template copy
            //////////////////////////
            ///
            /* TODO
            var copyModel = new MessageTemplate
            {
                Id = 5,
                DelayPeriodId = 1,
                DelayBeforeSend = 0,
                IsActive = true,
                Name = "Test template",
                Subject = "Test subject",
                Body = "Test body",
                AllowedTokens = "test",
                BccEmailAddresses = "email@email.cz",
                SendImmediately = true,
                HasAttachedDownload = false,
                AttachedDownloadName = "",
                EmailAccountId = 2
            };


            Console.WriteLine("Copying email template ...");
            var copiedTemplate = await _client.EmailTemplateCopy(copyModel);
            Console.WriteLine($"EmailCreate StatusCode = {copiedTemplate.StatusCode}, Id = {copiedTemplate?.Result}");
            */

        }
    }
}
