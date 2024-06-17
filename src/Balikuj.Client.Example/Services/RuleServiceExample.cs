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

using Balikuj.Client.Models.Rule;

namespace Balikuj.Client.Example.Services
{
    public class RuleServiceExample
    {
        private readonly BalikujClient _client;

        public RuleServiceExample(BalikujClient client)
        {
            _client = client;

            _client.SetApiKey(ApiRuntimeSettings.ApiKey);
        }

        public async Task RunAsync()
        {
            ///////////////
            /// Rule list
            //////////////

            
            Console.WriteLine("Getting rules ...");
            var ruleList = await _client.Rule.List();
            Console.WriteLine($"RuleList StatusCode = {ruleList.StatusCode}, Count = {ruleList?.Result?.Total}");
            

            ///////////////
            /// Rule fields
            //////////////

            
            Console.WriteLine("Getting rule fields ...");
            var fields = await _client.Rule.GetFields();
            Console.WriteLine($"RuleGetFields StatusCode = {fields.StatusCode}, Count = {fields?.Result?.Count}");
            

            ///////////////
            /// Rule detail
            //////////////

            
            int desiredId = 1;

            Console.WriteLine("Getting rule detail ...");
            var ruleDetail = await _client.Rule.Detail(desiredId);
            Console.WriteLine($"RuleGetFields StatusCode = {ruleDetail.StatusCode}, RuleName = {ruleDetail?.Result?.Name}");
            


            ///////////////
            /// Rule create
            //////////////

            
            var newRule = new RuleCreateRequest()
            {
                Name = "Zaplacené objednávky 2",
                Description = "Slouží pro zasílání emailů",
                Type = RuleType.Order,
                ValidFrom = DateTime.Now.ToString("yyyy-MM-dd"),
                ValidTo = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                UsageOneTimeOnly = false,
                SendOrderEmail = true,
                ValidDays = new RuleValidDays()
                {
                    Monday = true,
                    Tuesday = true,
                    Wednesday = true,
                    Thursday = true,
                    Friday = true,
                    Saturday = true,
                    Sunday = true
                },
                ValidTimes = new RuleValidTimes()
                {
                    Time0to6 = true,
                    Time6to12 = true,
                    Time12to18 = true,
                    Time18to24 = true
                },
                IsEnabled = true,
                Conditions = new List<RuleCondition>()
                {
                    new RuleCondition()
                    {
                        Field = "OrderNumber",
                        Operator = "NotEqualTo",
                        Value = "123"
                    }
                },
                Actions = new List<RuleAction>()
                {
                    new RuleActionChangeStatus()
                    {
                       Parameters = new Dictionary<string, string>()
                       {
                           { "statusId", "6" },
                           
                       },               
                    }
                }
            };

            Console.WriteLine("Creating rule ...");
            var createdRule = await _client.Rule.Create(newRule);
            Console.WriteLine($"RuleCreate StatusCode = {createdRule.StatusCode}, RuleName = {createdRule?.Result?.Name}");
           

            //////////////////
            /// Rule update
            /////////////////

            
            // int desiredId = 1;
            
            var updateRule = new RuleUpdateRequest()
            {
                Name = "Zaplacené objednávky 3",
                Description = "Slouží pro zasílání emailů",
                Type = RuleType.Order,
                ValidFrom = DateTime.Now.ToString("yyyy-MM-dd"),
                ValidTo = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                UsageOneTimeOnly = false,
                SendOrderEmail = true,
                ValidDays = new RuleValidDays()
                {
                    Monday = true,
                    Tuesday = true,
                    Wednesday = true,
                    Thursday = true,
                    Friday = true,
                    Saturday = true,
                    Sunday = true
                },
                ValidTimes = new RuleValidTimes()
                {
                    Time0to6 = true,
                    Time6to12 = true,
                    Time12to18 = true,
                    Time18to24 = true
                },
                IsEnabled = true,
                Conditions = new List<RuleCondition>()
                {
                    new RuleCondition()
                    {
                        Field = "OrderNumber",
                        Operator = "NotEqualTo",
                        Value = "123"
                    }
                },
                Actions = new List<RuleAction>()
                {
                    new RuleActionChangeStatus()
                    {
                       Parameters = new Dictionary<string, string>()
                       {
                           { "statusId", "6" },
                           
                       },               
                    }
                }
            };

            Console.WriteLine("Updating rule ...");
            var updatedRule = await _client.Rule.Update(desiredId, updateRule);
            Console.WriteLine($"RuleUpdate StatusCode = {updatedRule.StatusCode}, RuleName = {updatedRule?.Result?.Name}");
            

            
            /////////////////
            /// Rule delete
            /////////////////

            
            // int desiredId = 4;

            Console.WriteLine("Deleting rule ...");
            var deletedRule = await _client.Rule.Delete(desiredId);
            Console.WriteLine($"RuleDelete StatusCode = {deletedRule.StatusCode}, Success = {deletedRule?.Result}");
            


            /////////////////
            /// Rule MoveUp
            /////////////////

            
            // int desiredId = 3;

            Console.WriteLine("Moving rule up ...");
            var movedRuleUp = await _client.Rule.MoveUp(desiredId);
            Console.WriteLine($"RuleMoveUp StatusCode = {movedRuleUp.StatusCode}, Success = {movedRuleUp?.Result}");
            


            /////////////////
            /// Rule MoveDown
            /////////////////

            
            // int desiredId = 3;

            Console.WriteLine("Moving rule down ...");
            var movedRuleDown = await _client.Rule.MoveDown(desiredId);
            Console.WriteLine($"RuleMoveDown StatusCode = {movedRuleDown.StatusCode}, Success = {movedRuleDown?.Result}");
            

        }
    }
}
