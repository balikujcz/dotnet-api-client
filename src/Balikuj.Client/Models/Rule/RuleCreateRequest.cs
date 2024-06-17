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

using System.Collections.Generic;
using System.ComponentModel;
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
