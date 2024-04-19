using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Rule
{
    public class RuleCreateRequest
    {
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Type of the rule, can be for Orders or for Shipments
        /// </summary>
        [DefaultValue(RuleType.Order)]
        public RuleType Type { get; set; }

        /// <summary>
        /// Name of the rule
        /// </summary>
        /// <example>Testovací pravidlo</example>
        public string Name { get; set; }

        /// <summary>
        /// Description of the rule
        /// </summary>
        /// <example>Popis pravidla</example>
        public string Description { get; set; }

        /// <summary>
        /// Date when the rule is valid from. The date must be in the format YYYY-MM-DD.
        /// </summary>
        /// <example>2024-02-24</example>
        public string ValidFrom { get; set; }

        /// <summary>
        /// Date when the rule is valid to. The date must be in the format YYYY-MM-DD.
        /// </summary>
        /// <example>2024-02-25</example>
        public string ValidTo { get; set; }

        /// <summary>
        /// Is the rule for one time only?
        /// </summary>
        /// <example>false</example>
        public bool UsageOneTimeOnly { get; set; }

        /// <summary> 
        /// If is set to true, system emails will be sent (to the e-shop)
        /// </summary>
        /// <example>false</example>
        public bool SendOrderEmail { get; set; }

        /// <summary>
        /// Statements for creating rules
        /// </summary>
        public IList<RuleCondition> Conditions { get; set; } = new List<RuleCondition>();

        /// <summary>
        /// Actions
        /// </summary>
        public IList<RuleAction> Actions { get; set; } = new List<RuleAction>();

        /// <summary>
        /// Days when the rule is valid
        /// </summary>
        public RuleValidDays ValidDays { get; set; }

        /// <summary>
        /// Time when the rule is valid
        /// </summary>
        public RuleValidTimes ValidTimes { get; set; }

        /// <summary>
        /// Information whether the rule is active/inactive
        /// </summary>
        public bool? IsEnabled { get; set; }
    }
}
