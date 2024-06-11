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

            /*
            Console.WriteLine("Getting rules ...");
            var rules = await _client.Rule.List();
            Console.WriteLine($"RuleList StatusCode = {rules.StatusCode}, Count = {rules?.Result?.Total}");
            */

            ///////////////
            /// Rule fields
            //////////////

            /*
            Console.WriteLine("Getting rule fields ...");
            var fields = await _client.Rule.GetFields();
            Console.WriteLine($"RuleGetFields StatusCode = {fields.StatusCode}, Count = {fields?.Result?.Count}");
            */

            ///////////////
            /// Rule detail
            //////////////

            /*
            int desiredId = 1;

            Console.WriteLine("Getting rule detail ...");
            var ruleDetail = await _client.Rule.Detail(desiredId);
            Console.WriteLine($"RuleGetFields StatusCode = {ruleDetail.StatusCode}, RuleName = {ruleDetail?.Result?.Name}");
            */


            ///////////////
            /// Rule create
            //////////////

            /*
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
            */

            ///////////////
            /// Rule create
            //////////////

            /*
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
            */

            //////////////////
            /// Rule update
            /////////////////

            /*
            int desiredId = 1;
            
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
            */

            /*
            /////////////////
            /// Rule delete
            /////////////////

            
            int desiredId = 4;

            Console.WriteLine("Deleting rule ...");
            var deletedRule = await _client.Rule.Delete(desiredId);
            Console.WriteLine($"RuleDelete StatusCode = {deletedRule.StatusCode}, Success = {deletedRule?.Result}");
            */


            /////////////////
            /// Rule MoveUp
            /////////////////

            /*
            int desiredId = 3;

            Console.WriteLine("Moving rule up ...");
            var movedRule = await _client.Rule.MoveUp(desiredId);
            Console.WriteLine($"RuleMoveUp StatusCode = {movedRule.StatusCode}, Success = {movedRule?.Result}");
            */


            /////////////////
            /// Rule MoveDown
            /////////////////

            /*
            int desiredId = 3;

            Console.WriteLine("Moving rule down ...");
            var movedRule = await _client.Rule.MoveDown(desiredId);
            Console.WriteLine($"RuleMoveDown StatusCode = {movedRule.StatusCode}, Success = {movedRule?.Result}");
            */

        }
    }
}
