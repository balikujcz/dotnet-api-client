using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.EmailTemplate
{
    public class MessageTemplateSearchModel
    {
        /// <summary>
        /// search by name
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// search by email isActiveId
        /// </summary>
        public int IsActiveId { get; set; }
    }
}
