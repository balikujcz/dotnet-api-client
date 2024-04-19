using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Rule
{
    public class Rule
    {
        public RuleType Type { get; set; }

        /// <summary>
        /// Název pravidla
        /// </summary>
        /// <example>Zaplacené objednávky</example>
        public string Name { get; set; }

        /// <summary>
        /// Popis pravidla
        /// </summary>
        /// <example>Slouží pro zasílání emailů</example>
        public string Description { get; set; }

        /// <summary>
        /// Aktuálního stav pravidla
        /// </summary>
        /// <example>Active</example>
        public RuleStatus Status { get; set; }

        /// <summary>
        /// Datum vytvoření pravidla
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Datum poslední kontroly/stažení dat apod.
        /// </summary>
        public DateTime? LastSuccessful { get; set; }

        /// <summary>
        /// Datum platnosti pravidla od
        /// </summary>
        public string ValidFrom { get; set; }

        /// <summary>
        /// Datum platnosti pravidla do
        /// </summary>
        public string ValidTo { get; set; }

        /// <summary>
        /// Jedná se pouze o jednorázové spuštění pravidla?
        /// </summary>
        /// <example>true</example>
        public bool? UsageOneTimeOnly { get; set; }

        /// <summary>
        /// Pokud je nastaveno na true, odešlou se systémové emaily (na eshopu)
        /// </summary>
        /// <example>true</example>
        public bool SendOrderEmail { get; set; }

        /// <summary>
        /// Podmínky pro tvorbu pravidel
        /// </summary>
        public IList<RuleCondition> Conditions { get; set; } = new List<RuleCondition>();

        /// <summary>
        /// Akce, které se mají provést
        /// </summary>
        public IList<RuleAction> Actions { get; set; } = new List<RuleAction>();

        /// <summary>
        /// Dny, kdy pravidlo platí
        /// </summary>
        public RuleValidDays ValidDays { get; set; }

        /// <summary>
        /// Čas, kdy pravidlo platí
        /// </summary>
        public RuleValidTimes ValidTimes { get; set; }

        /// <summary>
        /// Informace, zda je pravidlo aktivní/neaktivní
        /// </summary>
        public bool? IsEnabled { get; set; }
    }
}
