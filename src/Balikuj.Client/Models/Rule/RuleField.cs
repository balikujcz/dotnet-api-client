using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Rule
{
    public class RuleField
	{
		[JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Type of the rule Order or Package
        /// </summary>
        /// <example>Order</example>
        public RuleType Type { get; set; }

        /// <summary>
        /// Name of the column to compare
        /// </summary>
        /// <example>OrderPaid</example>
        public string Field { get; set; }

        /// <summary>
        /// Name of the column - used for possible display on the web
        /// </summary>
        /// <example>Zaplacená déle než</example>
        public string Name { get; set; }

        /// <summary>
        /// Description of the column - used for possible display on the web
        /// </summary>
        /// <example>Allows you to create a rule for orders that have been paid for more than x days</example>   
        public string Description { get; set; }

        /// <summary>
        /// Overview of operators for comparing values. Operators can take the following values:
        /// </summary>
        /// <example>[&quot;EqualTo&quot;]</example>
        public IList<string> Operators { get; set; }

    }
}
