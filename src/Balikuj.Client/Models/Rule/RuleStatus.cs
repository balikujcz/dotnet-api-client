using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Rule
{
    public enum RuleStatus
    {
        Inactive = 0,

        Active = 1,

        WaitingActivation = 2,

        Deleted = 3
    }
}
