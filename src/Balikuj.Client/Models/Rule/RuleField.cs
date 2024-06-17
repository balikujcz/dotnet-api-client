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
