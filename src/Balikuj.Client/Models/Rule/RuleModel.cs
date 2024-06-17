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

using System;
using System.Collections.Generic;

namespace Balikuj.Client.Models.Rule
{
    public class RuleModel
    {
        public RuleType Type { get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        /// <example>Paid orders</example>
        public string Name { get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        /// <example>Used for sending emails</example>
        public string Description { get; set; }

        /// <summary>
        /// Current rule status
        /// </summary>
        /// <example>Active</example>
        public RuleStatus Status { get; set; }

        /// <summary>
        /// Rule creation date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date of last check/data download, etc.
        /// </summary>
        public DateTime? LastSuccessful { get; set; }

        /// <summary>
        /// Rule validity date from
        /// </summary>
        public string ValidFrom { get; set; }

        /// <summary>
        /// Rule validity date to
        /// </summary>
        public string ValidTo { get; set; }

        /// <summary>
        /// Is it a one-time rule execution only?
        /// </summary>
        /// <example>true</example>
        public bool? UsageOneTimeOnly { get; set; }

        /// <summary>
        /// If set to true, system emails will be sent (to the e-shop)
        /// </summary>
        /// <example>true</example>
        public bool SendOrderEmail { get; set; }

        /// <summary>
        /// Conditions for rule creation
        /// </summary>
        public IList<RuleCondition> Conditions { get; set; } = new List<RuleCondition>();

        /// <summary>
        /// Actions to be performed
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
        /// Information whether the rule is enabled/disabled
        /// </summary>
        public bool? IsEnabled { get; set; }
    }
}
