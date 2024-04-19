using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Rule
{
    public class RuleValidTimes
    {
        public bool? Time0to6 { get; set; }
        public bool? Time6to12 { get; set; }
        public bool? Time12to18 { get; set; }
        public bool? Time18to24 { get; set; }
    }
}
