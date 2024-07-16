using System.ComponentModel;

namespace Balikuj.Client.Models.Base
{
    public class BaseSearchModel
    {
        /// <summary>
        /// Default page number
        /// </summary>
        /// <example>1</example>
        [DefaultValue(1)]
        public int Page => (Start / Length) + 1;

        /// <summary>
        /// Number of records per page
        /// </summary>
        /// <example>50</example>
        [DefaultValue(50)]
        public virtual int PageSize
        {
            get => Length;
            set
            {
                if (value > 2000)
                {
                    Length = 1000;
                }
                else
                {
                    Length = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the number of rows to skip. Indicator of the first pagination record.
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// Gets or sets the page length. Number of records that the table can display in the current selection.
        /// </summary>
        [DefaultValue(50)]
        public int Length { get; set; } = 50;
    }
}
