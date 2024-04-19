using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Rule
{
    /// <summary>
    /// Model for creating action
	/// </summary>
	public class RuleAction
    {
        private string _name;

        /// <summary>
        /// Název akce
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
				//{ "From", ""},
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
