using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Application
{
    public class ApplicationTypeModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Unique code of the application
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Name of the application
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Short description of the application
        /// </summary>
        public string Description { get; set; }
    }
}
