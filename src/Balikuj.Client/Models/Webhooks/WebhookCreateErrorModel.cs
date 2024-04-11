using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Webhooks
{
    public class WebhookCreateErrorModel
    {

            /// <summary>
            /// Zadaná URL, která obsahuje chybu
            /// </summary>
            public string Url { get; set; }

            /// <summary>
            /// Popis chyby nebo chybové hlášení
            /// </summary>
            public string Error { get; set; }
       
    }
}
