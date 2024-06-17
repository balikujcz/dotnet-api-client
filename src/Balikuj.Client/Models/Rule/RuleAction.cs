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
    /// <summary>
    /// Model for creating action
	/// </summary>
	public class RuleAction
    {
        private string _name;

        /// <summary>
        /// Name of an action
        /// </summary>
        public string Name
        {
            get
            {
                if (_name.ToUpperInvariant() == "SENDEMAIL")
                {
                    return "SendEmail";
                }
                else if (_name.ToUpperInvariant() == "SENDEMAILTEMPLATE")
                {
                    return "SendEmailTemplate";
                }
                else if (_name.ToUpperInvariant() == "CHANGESTATUS")
                {
                    return "ChangeStatus";
                }
                else if (_name.ToUpperInvariant() == "HTTPPOST")
                {
                    return "HttpPost";
                }
                else if (_name.ToUpperInvariant() == "PRINT")
                {
                    return "Print";
                }
                else
                {
                    return _name;
                }

            }
            set { _name = value; }
        }

        /// <summary>
        /// Parameters of action
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }

    public class RuleActionSendEmail : RuleAction
    {
        public RuleActionSendEmail()
        {
            Name = "SendEmail";
            Parameters = new Dictionary<string, string>()
            {
                { "To", "" },
				{ "From", ""},
				{ "Subject", "" },
                { "Body", "" },
                { "HtmlBody", "" }
            };
        }
    }

    public class RuleActionSendEmailTemplate : RuleAction
    {
        public RuleActionSendEmailTemplate()
        {
            Name = "SendEmailTemplate";
            Parameters = new Dictionary<string, string>()
            {
                { "TemplateName", "" },
                { "To", "" }
            };
        }
    }

    public class RuleActionChangeStatus : RuleAction
    {
        // StatusId
        public RuleActionChangeStatus()
        {
            Name = "ChangeStatus";

            Parameters = new Dictionary<string, string>()
            {
                { "StatusId", "" }
            };

        }
    }

    public class RuleActionHttpPost : RuleAction
    {
        // URL
        public RuleActionHttpPost()
        {
            Name = "HttpPost";
            Parameters = new Dictionary<string, string>()
            {
                { "Url", "" }
            };
        }
    }

    public class RuleActionPrint : RuleAction
    {
        // TemplateId
        // PrinterName
        public RuleActionPrint()
        {
            Name = "Print";
            Parameters = new Dictionary<string, string>()
            {
                { "Type", "" },
                { "PrinterName", "" }
            };
        }
    }
}
